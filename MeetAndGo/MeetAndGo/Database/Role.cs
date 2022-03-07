using System;
using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class Role
    {
        public Role()
        {
            UserAccountRole = new HashSet<UserAccountRole>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserAccountRole> UserAccountRole { get; set; }
    }
}
