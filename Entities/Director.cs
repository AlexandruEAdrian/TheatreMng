using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.Entities
{
    public class Director: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserId { get; set; }

        public virtual List<Show> Shows { get; set; }
        public virtual User User { get; set; }
    }
}
