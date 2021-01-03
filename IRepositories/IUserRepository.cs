using TheatreMng.Entities;
using TheatreMng.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByUserAndPassword(string username, string password);
    }
}
