using TheatreMng.Entities;
using TheatreMng.IRepositories;
using TheatreMng.IServices;
using TheatreMng.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheatreMng.Services
{
    public class ShowService : IShowService
    {
        private readonly IShowRepository _repository;
        private readonly IActorShowRepository _actorShowRepository;
        

        public ShowService(IShowRepository repository, IActorShowRepository actorShowRepository)
        {
            this._repository = repository;
            this._actorShowRepository = actorShowRepository;
        }
     

        public bool Delete(int id)
        {
            var show = _repository.FindById(id);
            _repository.Delete(show);
            return _repository.SaveChanges();
        }

        public List<Show> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Show GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Show show)
        {
            _repository.Create(show);
            return _repository.SaveChanges();
        }

        public bool Update(Show show)
        {
            _repository.Update(show);
            return _repository.SaveChanges();
        }

        public bool RegisterActor(ShowActorRegister payload)
        {
            var entity = new ActorShow
            {
                ActorId = payload.ActorId,
                ShowId = payload.ShowId
            };

            _actorShowRepository.Create(entity);
            return _repository.SaveChanges();
        }
       

        public bool RemoveActorFromShow(ShowActorRegister payload)
        {
            var entity = _actorShowRepository.GetByActorAndShow(payload.ActorId, payload.ShowId);
            _actorShowRepository.HardDelete(entity);
            return _actorShowRepository.SaveChanges();
        }
        
    }
}
