using MuseumTest.Domain.Entities;
using MuseumTest.Repository;
using MuseumTest.Services.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumTest.Services.CustomServices
{
    public class CrudService<TEntity> : ICrudService<TEntity> where TEntity : BaseEntity
    {
        private readonly IRepository<TEntity> _entityRepository;

        public CrudService(IRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public void Delete(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    _entityRepository.Delete(entity);
                    _entityRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TEntity Get(int Id)
        {
            try
            {
                var obj = _entityRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                var obj = _entityRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    _entityRepository.Insert(entity);
                    _entityRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    _entityRepository.Remove(entity);
                    _entityRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                if (entity != null)
                {
                    _entityRepository.Update(entity);
                    _entityRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}