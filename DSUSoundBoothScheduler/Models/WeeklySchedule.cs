using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSUSoundBoothScheduler.Models
{
    public class WeeklySchedule
    {
        public Dictionary<DateTime, List<Reservation>> WeekdaySchedule { get; set; }
    }
}
