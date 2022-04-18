using System;

namespace MeetAndGo.Database
{
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }

        public virtual User User { get; set; }
    }
}
