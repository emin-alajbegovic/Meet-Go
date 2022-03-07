using System;

namespace MeetAndGo.Model.Requests
{
    public class UserAccountRoleUpsertRequest
    {
        public int UserAccountId { get; set; }
        public int RoleId { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
