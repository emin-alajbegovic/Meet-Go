using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class OfficeReviewController : BaseReadController<Model.OfficeReview, object>
    {
        public OfficeReviewController(IReadService<OfficeReview, object> service) : base(service) { }
    }
}
