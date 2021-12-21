using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MeetAndGo.Model.Requests
{
    public class UserInsertRequest
    {
        public int UserId { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(3)]
        [MaxLength(20)]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [MinLength(9)]
        [MaxLength(9)]
        public string PhoneNumber { get; set; }

    }
}
