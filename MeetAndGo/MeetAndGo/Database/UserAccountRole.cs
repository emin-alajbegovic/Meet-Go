using System;

namespace MeetAndGo.Database
{
    public partial class UserAccountRole
    {
        public int UserAccountRoleId { get; set; }
        public DateTime ChangeDate { get; set; }
        public int UserAccountId { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
