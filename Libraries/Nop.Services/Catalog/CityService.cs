//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Nop.Data;
//using Nop.Core.Domain.Catalog;

//namespace Nop.Services.Catalog
//{
//    public class CityService : ICityService
//    {
//        private readonly IRepository<City> _cityRepository;

//        public CityService(IRepository<City> cityRepository)
//        {
//            _cityRepository = cityRepository;
//        }

//        public async Task<List<City>> GetAllCitiesAsync()  // Change to async
//        {
//            return await _cityRepository.Table.OrderBy(c => c.Name).ToListAsync();  // Use ToListAsync for async operation
//        }

//        public City GetCityById(int cityId)
//        {
//            return _cityRepository.GetById(cityId);
//        }
//    }

//}
using Nop.Core.Domain.Common;
using Nop.Data;
using Nop.Services.Catalog;
using System.Collections.Generic;
using System.Linq;

namespace Nop.Services.Catalog
{
    public class CityService : ICityService
    {
        private readonly IRepository<City> _cityRepository;

        public CityService(IRepository<City> cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IList<City> GetAllCities()
        {
            var cities = _cityRepository.GetAll().ToList();
            return cities;
        }

    }

}


