using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MeetAndGo.Database
{
    public partial class Building
    {
        public Building()
        {
            BuildingReview = new HashSet<BuildingReview>();
            CanceledBuilding = new HashSet<CanceledBuilding>();
            RentedBuilding = new HashSet<RentedBuilding>();
        }

        public int BuildingId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Area { get; set; }
        public decimal Price { get; set; }
        public byte[] Picture { get; set; }
        public bool Rented { get; set; }
        public int NumberOfFloors { get; set; }
        [Browsable(false)]
        public int CityId { get; set; }
        [Browsable(false)]
        public int TypeOfBuildingId { get; set; }
        public int NumberOfOffices { get; set; }
        public bool IsDeleted { get; set; }
        public bool Security { get; set; }
        public bool Cameras { get; set; }
        public bool Parking { get; set; }

        public virtual City City { get; set; }
        public virtual TypeOfBuilding TypeOfBuilding { get; set; }
        public virtual ICollection<BuildingReview> BuildingReview { get; set; }
        public virtual ICollection<CanceledBuilding> CanceledBuilding { get; set; }
        public virtual ICollection<RentedBuilding> RentedBuilding { get; set; }
    }
}
