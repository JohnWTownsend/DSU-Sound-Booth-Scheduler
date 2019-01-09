using Data;
using Microsoft.AspNetCore.Identity;
using Services.Services;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DSUSoundBoothScheduler.ViewModels
{
    public class ReservationViewModel
    {

        public int Id { get; set; }
        public string ReservingUserId { get; set; }
        public DSUSoundBoothSchedulerUser ReservingUser { get; set; }

        [DisplayName("Reserver Name")]
        public string ReserverName { get; set; }

        [DisplayName("Reservation Name")]
        public string Name { get; set; }

        [DisplayName("Start Time")]
        public DateTime Start { get; set; }

        [DisplayName("End Time")]
        public DateTime End { get; set; }

        [DisplayName("Details")]
        public string Details { get; set; }

        [DisplayName("Color")]
        public string Color { get; set; }
    }
}