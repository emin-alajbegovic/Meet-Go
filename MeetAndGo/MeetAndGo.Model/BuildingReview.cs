namespace MeetAndGo.Model
{
    public partial class BuildingReview
    {
        public int BuildingReviewId { get; set; }
        public int UserId { get; set; }
        public int BuildingId { get; set; }
        public int Mark { get; set; }
    }
}
