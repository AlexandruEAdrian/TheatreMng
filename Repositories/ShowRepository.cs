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
    public class ShowRepository: GenericRepository<Show>, IShowRepository
    {
        public ShowRepository(TheaterDbContext context): base(context) { }

        public Show GetByIdJoined(int id)
        {
            var show = _context.Shows.Where(x => x.Id == id)
                .Include(x=>x.Director)
                .Include(x => x.ActorShows)
                    .ThenInclude(x=>x.Actor)
                .FirstOrDefault();
            return show;
        }
    }
}
