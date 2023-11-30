using Microsoft.AspNetCore.Mvc.Rendering;

namespace RoomReservationApp.Models
{
    public class ReservationViewModel
    {
        public int Id { get; set; }

        public int SelectedRoomId { get; set; }

        public string Customername { get; set; }

        public string CustomerPhoneNumber { get; set; }

        public string CustomerEmail { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public int Nights { get; set; }

        public float TotalCost { get; set; }

        public string Comments { get; set; }

        public List<Room> AvailableRooms { get; set; } = new List<Room>();
    }
}
