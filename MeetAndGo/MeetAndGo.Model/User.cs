namespace MeetAndGo.Model
{
    public partial class User
    {
        public User()
        {
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Rented { get; set; }
    }
}
