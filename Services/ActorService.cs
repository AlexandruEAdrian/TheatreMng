﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatreMng.IServices;
using TheatreMng.Entities;
using TheatreMng.IRepositories;

namespace TheatreMng.Services
{
    public class ActorService: IActorService
    {
        private readonly IActorRepository _repository;


        public ActorService(IActorRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var actor = _repository.FindById(id);
            _repository.Delete(actor);
            return _repository.SaveChanges();
        }

        public List<Actor> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Actor GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Insert(Actor actor)
        {
            _repository.Create(actor);
            return _repository.SaveChanges();
        }

        public bool Update(Actor actor)
        {
            _repository.Update(actor);
            return _repository.SaveChanges();
        }
    }
}
