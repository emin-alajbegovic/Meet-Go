namespace MeetAndGo.Database
{
    public partial class BuildingReview
    {
        public int BuildingReviewId { get; set; }
        public int UserId { get; set; }
        public int BuildingId { get; set; }
        public int Mark { get; set; }

        public virtual Building Building { get; set; }
        public virtual User User { get; set; }
    }
}
