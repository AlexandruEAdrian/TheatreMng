using TheatreMng.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.IServices
{
    public interface IActorService
    {
        List<Actor> GetAll();
        Actor GetById(int id);
        bool Insert(Actor actor);
        bool Update(Actor actor);
        bool Delete(int id);
    }
}
