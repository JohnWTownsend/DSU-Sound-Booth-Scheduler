using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Details { get; set; }
        public string Color { get; set; }
        [ForeignKey("ReservingUserId")]
        public string ReservingUserId { get; set; }
        public DSUSoundBoothSchedulerUser ReservingUser { get; set; }
    }
}
