using TheatreMng.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.IServices
{
    public interface IDirectorService
    {
        List<Director> GetAll();
        Director GetById(int id);
        bool Insert(Director director);
        bool Update(Director director);
        bool Delete(int id);
    }
}
