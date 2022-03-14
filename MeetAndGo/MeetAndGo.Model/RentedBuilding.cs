using System;
using System.ComponentModel;

namespace MeetAndGo.Model
{
    public partial class RentedBuilding
    {
        [Browsable(false)]
        public int RentedBuildingId { get; set; }
        [Browsable(false)]
        public int BuildingId { get; set; }
        [Browsable(false)]
        public int UserId { get; set; }
        [Browsable(false)]
        public DateTime BeginRentalDate { get; set; }
        [Browsable(false)]
        public DateTime EndRentalDate { get; set; }
        [Browsable(false)]
        public bool Rented { get; set; }
        public string Building { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public decimal Price { get; set; }
        public string Adress { get; set; }
        public byte[] Picture { get; set; }
        //[Browsable(false)]
        //public virtual User User { get; set; }
        //[Browsable(false)]
        //public virtual Building Building { get; set; }
    }
}
