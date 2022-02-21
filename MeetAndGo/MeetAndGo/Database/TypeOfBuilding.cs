using System;
using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class TypeOfBuilding
    {
        public TypeOfBuilding()
        {
            Building = new HashSet<Building>();
        }

        public int TypeOfBuildingId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Building> Building { get; set; }
    }
}
