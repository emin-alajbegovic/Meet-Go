using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class BuildingReviewController : BaseReadController<Model.BuildingReview, object>
    {
        public BuildingReviewController(IReadService<BuildingReview, object> service) : base(service) { }
    }
}
