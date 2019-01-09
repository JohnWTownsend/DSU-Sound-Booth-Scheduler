using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IReservationService
    {
        Reservation GetReservationById(int id);
        void AddReservation(Reservation reservation);
        void DeleteReservation(int id);
        List<Reservation> GetReservations(DateTime weekStart, DateTime weekEnd);
        void UpdateReservation(Reservation reservation);
    }
}
