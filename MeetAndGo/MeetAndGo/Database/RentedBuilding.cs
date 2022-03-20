using System;




namespace MeetAndGo.Database
{
    public partial class RentedBuilding
    {
        public int RentedBuildingId { get; set; }
        public int BuildingId { get; set; }
        public int UserId { get; set; }
        public DateTime BeginRentalDate { get; set; }
        public DateTime EndRentalDate { get; set; }
        public bool Rented { get; set; }
        public int Days { get; set; }
        public decimal Price { get; set; }

        public virtual Building Building { get; set; }
        public virtual User User { get; set; }
    }
}
