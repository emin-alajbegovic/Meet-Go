using System;

namespace MeetAndGo.Model
{
    public partial class UserAccountRole
    {
        public int UserAccountRoleId { get; set; }
        public int UserAccountId { get; set; }
        public int RoleId { get; set; }
        public DateTime ChangeDate{ get; set; }
        public virtual Role Role { get; set; }
    }
}
