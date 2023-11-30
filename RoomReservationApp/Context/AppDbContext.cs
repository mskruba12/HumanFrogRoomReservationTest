using Microsoft.EntityFrameworkCore;
using RoomReservationApp.Models;

namespace RoomReservationApp.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {
           
        }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
