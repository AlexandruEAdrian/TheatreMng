using TheatreMng.Data;
using TheatreMng.Entities;
using TheatreMng.Repositories;
using TheatreMng.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(TheaterDbContext context) : base(context)
        {
        }

        public User GetByUserAndPassword(string username, string password)
        {
            return _table.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
