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
    public class MuseumsService : CrudService<Museum>, IMuseumService
    {
        private readonly IRepository<Museum> _museumRepository;


        public MuseumsService(IRepository<Museum> museumRepository) : base(museumRepository)
        {
            _museumRepository = museumRepository;
        }

        public CrudService<Museum> GetCrud()
        {
            return this;
        }


        public IEnumerable<Museum> GetMuseumsType(string type)
        {
            var museums = _museumRepository.GetAll().Where(m => m.Type == type);
            return museums;
        }
    }
}
