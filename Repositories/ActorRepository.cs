using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatreMng.Data;
using TheatreMng.Entities;
using TheatreMng.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace TheatreMng.Repositories
{
    public class ActorRepository: GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(TheaterDbContext context): base(context) { }

        public Actor GetByIdJoined(int id)
        {
            var actor = _context.Actors.Where(x => x.Id == id)
                .Include(x => x.ActorShows)
                .FirstOrDefault();
            return actor;
        }
    }
}
