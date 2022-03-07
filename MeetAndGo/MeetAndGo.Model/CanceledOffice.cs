using System;

namespace MeetAndGo.Model
{
    public partial class CanceledOffice
    {
        public int CanceledOfficeId { get; set; }
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public DateTime CancelDate { get; set; }
        public bool Fee { get; set; }
        public decimal? FeePrice { get; set; }
    }
}
