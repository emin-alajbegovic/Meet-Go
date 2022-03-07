using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class TransactionsController : BaseReadController<Model.Transactions, object>
    {
        public TransactionsController(IReadService<Transactions, object> service) : base(service) { }
    }
}
