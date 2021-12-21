using System;
using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class Office
    {
        public Office()
        {
            CanceledOffice = new HashSet<CanceledOffice>();
            OfficeReview = new HashSet<OfficeReview>();
            RentedOffice = new HashSet<RentedOffice>();
        }

        public int OfficeId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Area { get; set; }
        public string Picture { get; set; }
        public decimal Price { get; set; }
        public bool Rented { get; set; }
        public int NumberOfFloors { get; set; }
        public int CityId { get; set; }
        public int TypeOfOfficeId { get; set; }
        public bool IsDeleted { get; set; }
        public bool Parking { get; set; }
        public bool Cameras { get; set; }

        public virtual City City { get; set; }
        public virtual TypeOfOffice TypeOfOffice { get; set; }
        public virtual ICollection<CanceledOffice> CanceledOffice { get; set; }
        public virtual ICollection<OfficeReview> OfficeReview { get; set; }
        public virtual ICollection<RentedOffice> RentedOffice { get; set; }
    }
}
