using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatreMng.Entities;

namespace TheatreMng.IRepositories
{
    public interface IActorShowRepository : IGenericRepository<ActorShow>
    {
        ActorShow GetByActorAndShow(int actor, int show);
    }
}
