using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using AutoMapper;
using DAL.Repository;
using QuestRooms.bll.Mapping;
using QuestRooms.bll.Services.Abstraction;
using QuestRooms.bll.Services.Implementation;
using QuestRooms.dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.ui.App_Start
{
    public class AutoFacConfig
    {
        public static void ConfigurateAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            RegisterTypes(builder);
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            var mapConfig = new MapperConfiguration(cfg=>cfg.AddProfile<MapperProfile>());

            var mapper = new Mapper(mapConfig);

            builder.RegisterInstance(mapper).As<IMapper>();
                                                          
            builder.RegisterType<QuestRoomContext>().As<DbContext>();
            builder.RegisterType(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));

            builder.RegisterType<CityService>().As<ICityService>();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
            




        }

      
    }
}