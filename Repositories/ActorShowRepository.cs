using TheatreMng.Data;
using TheatreMng.Entities;
using TheatreMng.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.Repositories
{
    public class ActorShowRepository : GenericRepository<ActorShow>, IActorShowRepository
    {
        public ActorShowRepository(TheaterDbContext context) : base(context)
        {
        }

        public ActorShow GetByActorAndShow(int actor, int show)
        {
            return _context.ActorShows.Where(x => x.ActorId == actor && x.ShowId == show)
                .FirstOrDefault();
        }
    }
}
