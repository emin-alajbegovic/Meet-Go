using System;

namespace MeetAndGo.Model
{
    public partial class Transactions
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}
