using System;
using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class UserAccount
    {
        public UserAccount()
        {
            User = new HashSet<User>();
            UserAccountRole = new HashSet<UserAccountRole>();
        }

        public int UserAccountId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }

        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserAccountRole> UserAccountRole { get; set; }
    }
}
