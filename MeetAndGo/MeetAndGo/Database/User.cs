using System;
using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class User
    {
        public User()
        {
            BuildingReview = new HashSet<BuildingReview>();
            CanceledBuilding = new HashSet<CanceledBuilding>();
            CanceledOffice = new HashSet<CanceledOffice>();
            OfficeReview = new HashSet<OfficeReview>();
            RentedBuilding = new HashSet<RentedBuilding>();
            RentedOffice = new HashSet<RentedOffice>();
            Transactions = new HashSet<Transactions>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int UserAccountId { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        public virtual ICollection<BuildingReview> BuildingReview { get; set; }
        public virtual ICollection<CanceledBuilding> CanceledBuilding { get; set; }
        public virtual ICollection<CanceledOffice> CanceledOffice { get; set; }
        public virtual ICollection<OfficeReview> OfficeReview { get; set; }
        public virtual ICollection<RentedBuilding> RentedBuilding { get; set; }
        public virtual ICollection<RentedOffice> RentedOffice { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
