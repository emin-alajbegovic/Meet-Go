using System;

namespace MeetAndGo.Model.Requests
{
    public class RentedBuildingUpdateRequest
    {
        public int BuildingId { get; set; }
        public int UserId { get; set; }
        public DateTime BeginRentalDate { get; set; }
        public DateTime EndRentalDate { get; set; }
        public bool Rented { get; set; }
    }
}
