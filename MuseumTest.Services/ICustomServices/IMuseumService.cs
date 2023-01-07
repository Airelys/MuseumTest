using MuseumTest.Domain.Entities;
using MuseumTest.Services.CustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumTest.Services.ICustomServices
{
    public interface IMuseumService
    {
        CrudService<Museum> GetCrud();
        IEnumerable<Museum> GetMuseumsType(string type);
    }
}
