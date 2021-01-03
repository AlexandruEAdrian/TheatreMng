using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.Entities
{
    public class Show: BaseEntity
    {
        public string Title { get; set; } 


        public int? DirectorId { get; set; }

        public virtual List<ActorShow> ActorShows { get; set; }
        public virtual Director  Director{ get; set; }
    }
}
