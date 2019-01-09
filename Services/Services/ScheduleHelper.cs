using Data;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Services
{
    public class ScheduleHelper : IScheduleHelper
    {
        public List<Reservation> GetWeekdayReservations(List<Reservation> reservations, int dayOfWeek)
        {
            return reservations.Where(x => (int)x.Start.DayOfWeek == dayOfWeek).ToList();
        }
    }
}

