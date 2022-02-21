﻿using System;
using System.Collections.Generic;

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

        public virtual Building Building { get; set; }
        public virtual User User { get; set; }
    }
}
