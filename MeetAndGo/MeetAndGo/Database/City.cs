using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class City
    {
        public City()
        {
            Building = new HashSet<Building>();
            Office = new HashSet<Office>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Building> Building { get; set; }
        public virtual ICollection<Office> Office { get; set; }
    }
}
