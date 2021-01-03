using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.Entities
{
    public class ActorShow: BaseEntity
    {
        public int ActorId { get; set; }
        public int ShowId { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Show Show { get; set; }
    }
}
