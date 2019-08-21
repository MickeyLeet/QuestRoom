using QuestRooms.bll.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.ui.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService cityService;
        public String Index(ICityService _cityservice)
        {
            var cities = cityService.GetAllCities();
            return  "Hello";
        }


        public CityController (ICityService _cityservice)
        {
            cityService = _cityservice;

        }

    }
}