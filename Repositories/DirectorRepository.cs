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
    public class DirectorRepository: GenericRepository<Director>, IDirectorRepository
    {
        public DirectorRepository(TheaterDbContext context): base(context) { }

        public Director GetByIdJoined(int id)
        {
            var director = _context.Directors.Where(x => x.Id == id)
                .Include(x => x.Shows)
                .FirstOrDefault();
            return director;
        }
    }
}
