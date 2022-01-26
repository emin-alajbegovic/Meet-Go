using System.Collections.Generic;

namespace MeetAndGo.Database
{
    public partial class TypeOfOffice
    {
        public TypeOfOffice()
        {
            Office = new HashSet<Office>();
        }

        public int TypeOfOfficeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Office> Office { get; set; }
    }
}
