using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheatreMng.IServices;
using TheatreMng.Entities;
using TheatreMng.IRepositories;

namespace TheatreMng.Services
{
    public class DirectorService: IDirectorService
    {
        private readonly IDirectorRepository _repository;


        public DirectorService(IDirectorRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var director = _repository.FindById(id);
            _repository.Delete(director);
            return _repository.SaveChanges();
        }

        public List<Director> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Director GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Insert(Director director)
        {
            _repository.Create(director);
            return _repository.SaveChanges();
        }

        public bool Update(Director director)
        {
            _repository.Update(director);
            return _repository.SaveChanges();
        }
    }
}
