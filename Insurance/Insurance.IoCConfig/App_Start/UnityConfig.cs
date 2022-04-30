using Insurance.DAL.Interfaces;
using Insurance.DAL.Models.DomainModels.Insurance;
using Insurance.DAL.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace Insurance.IoCConfig
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IInsuranceCalculator, InsuranceCalculator>();
            container.RegisterType<IInsuranceTypeRepository, InsuranceTypeRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}