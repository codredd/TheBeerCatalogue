﻿using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using TheBeerCatalogue.Business;

namespace TheBeerCatalogue.Autofac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // Register dependencies in filter attributes
            builder.RegisterFilterProvider();

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterType<BeerFacade>().
                As<BeerInterface>();

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}