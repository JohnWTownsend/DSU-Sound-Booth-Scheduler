using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DSUSoundBoothScheduler.Models;
using Services.Interfaces;
using Data;
using DSUSoundBoothScheduler.ViewModels;
using Microsoft.AspNetCore.Identity;
using Services.Services;
using Microsoft.AspNetCore.Authorization;
using System.Drawing;

namespace DSUSoundBoothScheduler.Controllers
{
    public class HomeController : Controller
    {
        private IReservationService _reservationService;
        private IScheduleHelper _scheduleHelper;
        private UserManager<DSUSoundBoothSchedulerUser> _userManager;
        private IUserService _userService;

        public HomeController(IReservationService reservationService, IScheduleHelper scheduleHelper, UserManager<DSUSoundBoothSchedulerUser> userManager, IUserService userService)
        {
            _reservationService = reservationService;
            _scheduleHelper = scheduleHelper;
            _userManager = userManager;
            _userService = userService;
        }

        public IActionResult Index(DateTime? weekStart, DateTime? weekEnd)
        {
            List<Reservation> reservations;
            ViewBag.UserId = _userManager.GetUserId(HttpContext.User);

            if (weekStart == null && weekEnd == null)
            {
                DateTime now = DateTime.Today.Date;
                weekStart = now.AddDays(-(int)now.DayOfWeek);
                weekEnd = now.AddDays(7 - (int)now.DayOfWeek).AddMilliseconds(-1);
                reservations = _reservationService.GetReservations((DateTime)weekStart, (DateTime)weekEnd);
            }
            else
            {
                reservations = _reservationService.GetReservations((DateTime)weekStart, (DateTime)weekEnd);
            }
            var foo = User.HasClaim("IsAdmin", "True");
            WeeklySchedule weeklySchedule = new WeeklySchedule();
            weeklySchedule.WeekdaySchedule = new Dictionary<DateTime, List<Reservation>>();

            var weekDates = new List<DateTime>();

            for (var dt = weekStart; dt <= weekEnd; dt = ((DateTime)dt).AddDays(1))
            {
                weekDates.Add(((DateTime)dt).Date);
            }

            foreach (var date in weekDates)
            {
                weeklySchedule.WeekdaySchedule.Add(date, _scheduleHelper.GetWeekdayReservations(reservations, (int)date.DayOfWeek));
            }
            var x = weeklySchedule.WeekdaySchedule.First().Key.Date;

            return View(weeklySchedule);
        }

        public ActionResult PreviousWeekIndex(DateTime current)
        {
            DateTime weekStart = current.AddDays(-(int)current.DayOfWeek - 7);
            DateTime weekEnd = current.AddDays(6 - (int)current.DayOfWeek - 7);
            return RedirectToAction("Index", new { weekStart, weekEnd });
        }

        public ActionResult NextWeekIndex(DateTime current)
        {
            DateTime weekStart = current.AddDays(-(int)current.DayOfWeek + 7);
            DateTime weekEnd = current.AddDays(6 - (int)current.DayOfWeek + 7);
            return RedirectToAction("Index", new { weekStart, weekEnd });
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> AddReservation()
        {
            ReservationViewModel reservationViewModel = new ReservationViewModel();
            DateTime now = DateTime.Now;
            var user = await _userManager.GetUserAsync(HttpContext.User);
            reservationViewModel.ReserverName = user.FirstName + " " + user.LastName;
            reservationViewModel.Start = now;
            reservationViewModel.End = now.AddHours(1);
            return View(reservationViewModel);
        }

        [HttpGet]
        public async Task<ActionResult> AddReservationForWeekday(long ticks)
        {
            DateTime startDate = new DateTime(ticks);
            ReservationViewModel reservationViewModel = new ReservationViewModel();
            if (startDate != DateTime.MinValue)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                reservationViewModel.ReserverName = user.FirstName + " " + user.LastName;
                reservationViewModel.Start = (DateTime)startDate;
                reservationViewModel.End = (DateTime)startDate.AddHours(1);
            }
            return View("AddReservation", reservationViewModel);
        }

        [HttpPost]
        public async Task<ActionResult> AddReservation(ReservationViewModel reservationViewModel)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            Reservation reservation = new Reservation
            {
                ReservingUserId = user.Id,
                ReservingUser = user,
                Name = reservationViewModel.Name,
                Start = reservationViewModel.Start,
                End = reservationViewModel.End,
                Details = reservationViewModel.Details,
                Color = reservationViewModel.Color.Contains("#") ? reservationViewModel.Color : $"#{reservationViewModel.Color}",
            };
            _reservationService.AddReservation(reservation);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditReservation(int reservationId)
        {
            var reservation = _reservationService.GetReservationById(reservationId);
            var reserver = _userService.GetUserById(reservation.ReservingUserId);
            
            ReservationViewModel reservationViewModel = new ReservationViewModel
            {
                Id = reservation.Id,
                ReservingUser = reservation.ReservingUser,
                ReservingUserId = reservation.ReservingUserId,
                ReserverName = reserver.FirstName + " " + reserver.LastName,
                Name = reservation.Name,
                Start = reservation.Start,
                End = reservation.End,
                Details = reservation.Details,
                Color = reservation.Color,
            };
            return View(reservationViewModel);
        }

        [HttpPost]
        public ActionResult EditReservation(ReservationViewModel reservationViewModel)
        {
            
            var reservation = new Reservation
            {
                ReservingUserId = reservationViewModel.ReservingUserId,
                ReservingUser = reservationViewModel.ReservingUser,
                Id = reservationViewModel.Id,
                Name = reservationViewModel.Name,
                Start = reservationViewModel.Start,
                End = reservationViewModel.End,
                Details = reservationViewModel.Details,
                Color = reservationViewModel.Color.Contains("#") ? reservationViewModel.Color : $"#{reservationViewModel.Color}",
            };
            _reservationService.UpdateReservation(reservation);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteReservation(int reservationId)
        {
            var reservation = _reservationService.GetReservationById(reservationId);

            return View(reservation);
        }

        [HttpPost]
        public ActionResult DeleteReservationConfirm(int id)
        {
            _reservationService.DeleteReservation(id);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
