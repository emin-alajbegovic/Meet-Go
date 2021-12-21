using System;
using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class OfficeReview
    {
        public int OfficeReviewId { get; set; }
        public int UserId { get; set; }
        public int OfficeId { get; set; }
        public int Mark { get; set; }

        public virtual Office Office { get; set; }
        public virtual User User { get; set; }
    }
}
