using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Practices.Unity;
using WebApplicationMvc.Interfaces;

namespace WebApplicationMvc
{
    public class InjectionModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);

            using (var context = new MyContext(optionsBuilder.Options)) context.Database.EnsureCreated();
            container.RegisterType<MyContext>(new InjectionConstructor(optionsBuilder.Options));
        }
    }
}