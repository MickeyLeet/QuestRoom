using AutoMapper;
using DAL.Repository;
using QuestRooms.bll.DtoModels;
using QuestRooms.bll.Services.Abstraction;
using QuestRooms.dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.bll.Services.Implementation
{
    public class CityService : ICityService
    {
        private readonly IGenericRepository<City> cityRepos;

        private readonly IMapper mapper;

        public CityService(IGenericRepository<City> _cityRepos,
                           IMapper _mapper)
        {
            cityRepos = _cityRepos;
            mapper = _mapper;
        }

        public ICollection<CityDto> GetAllCities()
        {
            var cities = cityRepos.GetAll();
            return mapper.Map<IEnumerable<City>, ICollection<CityDto>>(cities);
        }
    }
}
