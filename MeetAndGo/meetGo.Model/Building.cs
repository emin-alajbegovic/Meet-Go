using System;
using System.Collections.Generic;

#nullable disable

namespace MeetAndGo.Model
{
    public partial class Building
    {
        public Building()
        {
        }

        public int BuildingId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Area { get; set; }
        public decimal Price { get; set; }
        public string Picture { get; set; }
        public bool Rented { get; set; }
        public int NumberOfFloors { get; set; }
        public int CityId { get; set; }
        public int TypeOfBuildingId { get; set; }
        public int NumberOfOffices { get; set; }
        public bool IsDeleted { get; set; }
        public bool Security { get; set; }
        public bool Cameras { get; set; }
        public bool Parking { get; set; }
    }
}
