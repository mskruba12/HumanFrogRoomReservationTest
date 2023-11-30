using System.ComponentModel.DataAnnotations.Schema;

namespace RoomReservationApp.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public Room Room { get; set; }

        public string Customername { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public string CustomerEmail { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public int Nights { get; set; }

        public float TotalCost { get; set; }

        public string Comments { get; set; }

        [NotMapped]
        public List<Room> AvailableRooms { get; set; } = new List<Room>();
    }
}
