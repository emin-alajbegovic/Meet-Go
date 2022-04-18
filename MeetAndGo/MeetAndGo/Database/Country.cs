﻿using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class Country
    {
        public Country()
        {
            City = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
