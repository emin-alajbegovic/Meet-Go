using System;

namespace MeetAndGo.Model
{
    public partial class CanceledBuilding
    {
        public int CanceledBuildingId { get; set; }
        public int UserId { get; set; }
        public int BuildingId { get; set; }
        public DateTime CancelDate { get; set; }
        public bool Fee { get; set; }
        public decimal? FeePrice { get; set; }
    }
}
