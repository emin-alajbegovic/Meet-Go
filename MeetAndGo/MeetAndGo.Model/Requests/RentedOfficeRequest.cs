using System;

namespace MeetAndGo.Model.Requests
{
    public class RentedOfficeRequest
    {
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public DateTime BeginRentalDate { get; set; }
        public DateTime EndRentalDate { get; set; }
        public bool Rented { get; set; }
        public int Days { get; set; }
        public decimal Price { get; set; }
    }
}
