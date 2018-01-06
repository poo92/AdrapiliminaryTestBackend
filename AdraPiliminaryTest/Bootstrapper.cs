using System.Web.Mvc;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using BusinessLogicLayer.Services.Interfaces;
using BusinessLogicLayer.Services;
using Unity.AspNet.Mvc;

namespace AdraPiliminaryTest
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // register dependency resolver for WebAPI RC
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IAccountBalanceService, AccountBalanceService>();
            container.RegisterType<IAccountBalanceRepository, AccountBalanceRepository>();

            return container;
        }
    }
}