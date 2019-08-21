using AutoMapper;
using QuestRooms.bll.DtoModels;
using QuestRooms.dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.bll.Mapping
{
    public class MapperProfile : Profile
    {


        public MapperProfile()
        {
            CreateMap<City, CityDto>();
        }

        private readonly IMapper mapper;


    }

}
