using TheatreMng.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatreMng.Models;

namespace TheatreMng.IServices
{
    public interface IShowService
    {
        List<Show> GetAll();
        Show GetById(int id);
        bool Insert(Show show);
        bool Update(Show show);
        bool Delete(int id);

        bool RegisterActor(ShowActorRegister paylaod);
       


    }
}
