using System.ComponentModel;

namespace MeetAndGo.Model
{
    public partial class Office
    {
        [Browsable(false)]
        public int OfficeId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        [Browsable(false)]
        public string Description { get; set; }
        public string Area { get; set; }
        public decimal Price { get; set; }
        public byte[] Picture { get; set; }
        public bool Rented { get; set; }
        [Browsable(false)]
        public int NumberOfFloors { get; set; }
        [Browsable(false)]
        public int CityId { get; set; }
        [Browsable(false)]
        public int TypeOfOfficeId { get; set; }
        [Browsable(false)]
        public bool IsDeleted { get; set; }
        [Browsable(false)]
        public bool Parking { get; set; }
        [Browsable(false)]
        public bool Cameras { get; set; }
    }
}
