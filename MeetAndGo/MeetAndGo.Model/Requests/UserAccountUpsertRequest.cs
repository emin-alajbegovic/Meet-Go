using System;
using System.Collections.Generic;
using System.Text;

namespace MeetAndGo.Model.Requests
{
    public class UserAccountUpsertRequest
    {
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
