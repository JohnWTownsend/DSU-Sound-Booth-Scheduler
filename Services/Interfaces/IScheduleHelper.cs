using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.Interfaces
{
    public interface IScheduleHelper
    {
        List<Reservation> GetWeekdayReservations(List<Reservation> reservations, int dayOfWeek);
    }
}
