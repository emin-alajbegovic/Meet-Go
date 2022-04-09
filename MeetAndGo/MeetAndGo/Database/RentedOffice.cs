using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeetAndGo.Database
{
    public partial class RentedOffice
    {
        public int RentedOfficeId { get; set; }
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public DateTime BeginRentalDate { get; set; }
        public DateTime EndRentalDate { get; set; }
        public bool Rented { get; set; }
        public int Days { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public virtual Office Office { get; set; }
        public virtual User User { get; set; }
    }
}
