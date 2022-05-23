using System;

namespace MeetAndGo.Model.Requests
{
    public class RentedBuildingRequest
    {
        public int BuildingId { get; set; }
        public int UserId { get; set; }
        public DateTime BeginRentalDate { get; set; }
        public DateTime EndRentalDate { get; set; }
        public bool Rented { get; set; }
        public int Days { get; set; }
        public decimal Price { get; set; }
    }
}