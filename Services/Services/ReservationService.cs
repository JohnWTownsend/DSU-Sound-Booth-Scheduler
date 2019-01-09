using Data;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Services
{
    public class ReservationService : IReservationService
    {
        private DSUSoundBoothSchedulerContext _dsuapContext;
        public ReservationService(DSUSoundBoothSchedulerContext dsuapContext)
        {
            _dsuapContext = dsuapContext;
        }

        public void AddReservation(Reservation reservation)
        {
            _dsuapContext.Reservation.Add(reservation);
            _dsuapContext.SaveChanges();
        }

        public void DeleteReservation(int id)
        {
            var reservation = _dsuapContext.Reservation.Where(x => x.Id == id).First();
            _dsuapContext.Reservation.Remove(reservation);
            _dsuapContext.SaveChanges();
        }

        public Reservation GetReservationById(int id)
        {
            return _dsuapContext.Reservation.Where(x => x.Id == id).First();
        }

        public void UpdateReservation(Reservation reservation)
        {
            _dsuapContext.Reservation.Update(reservation);
            _dsuapContext.SaveChanges();
        }

        public List<Reservation> GetReservations(DateTime weekStart, DateTime weekEnd)
        {
            var reservations = _dsuapContext.Reservation.Include(x => x.ReservingUser)
                                            .Where(x => x.Start >= weekStart && x.End <= weekEnd)
                                            .ToList();
            return reservations;
        }

    }
}
