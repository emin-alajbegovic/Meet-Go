using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MeetAndGo.Model
{
    public class UserAccount
    {
        public int UserAccountId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Username { get; set; }
        [Browsable(false)]
        public virtual ICollection<UserAccountRole> UserAccountRole { get; set; }

    }
}
