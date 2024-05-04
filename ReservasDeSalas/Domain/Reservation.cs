using System;

namespace ReservationSystem.Models 
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Room { get; set; }
    }
}

