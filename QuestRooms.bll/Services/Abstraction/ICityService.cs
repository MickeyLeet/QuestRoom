using QuestRooms.bll.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.bll.Services.Abstraction
{
    public interface ICityService
    {
        ICollection<CityDto> GetAllCities();

    }
}
