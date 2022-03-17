using System;

namespace MeetAndGo.Model.Requests
{
    public class RentedOfficeUpdateRequest
    {
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public DateTime BeginRentalDate { get; set; }
        public DateTime EndRentalDate { get; set; }
        public bool Rented { get; set; }
    }
}
