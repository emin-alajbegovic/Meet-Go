namespace MeetAndGo.Model.Requests
{
    public class UserUpsertRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public int UserAccountId { get; set; }
    }
}
