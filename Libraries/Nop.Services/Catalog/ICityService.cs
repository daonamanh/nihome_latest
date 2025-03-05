//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Nop.Core.Domain.Catalog;

//namespace Nop.Services.Catalog
//{
//    public interface ICityService
//    {
//        Task<List<City>> GetAllCitiesAsync(); // Change to async
//        City GetCityById(int cityId);
//    }

//}
using Nop.Core.Domain.Common;
using System.Collections.Generic;

namespace Nop.Services.Catalog
{
    public interface ICityService
    {
        IList<City> GetAllCities();
    }
}


