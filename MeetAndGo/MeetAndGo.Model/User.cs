using System.ComponentModel;

namespace MeetAndGo.Model
{
    public partial class User
    {
        public User()
        {
        }

        [Browsable(false)]
        public int UserId { get; set; }
        [Browsable(false)]
        public int UserAccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Browsable(false)]
        public bool Rented { get; set; }
    }
}
