using Microsoft.EntityFrameworkCore;
using ReservationSystem.Models;
using System.Collections.Generic;

namespace ReservationSystem.Data
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
