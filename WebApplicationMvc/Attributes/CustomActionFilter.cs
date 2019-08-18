using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WebApplicationMvc.Interfaces;
using WebApplicationMvc.Models;
using WebApplicationMvc.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApplicationMvc.Attributes
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var logFilter = GetService<ILogInterface>(actionContext);
            if(System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                logFilter.Insert(new FilterModel()
                {
                    ActionName = actionContext.Request.GetActionDescriptor().ActionName,
                    ControllerName = actionContext.Request.GetActionDescriptor().ControllerDescriptor.ControllerName,
                    CorreltionId =actionContext.Request.GetCorrelationId().ToString(),
                    DateTime = new DateTime().ToLocalTime(),
                    UserName = System.Web.HttpContext.Current.User.Identity.Name
                });
            }
        }

        private T GetService<T>(HttpActionContext actionContext)
        {
            return (T)actionContext.Request.GetDependencyScope().GetService(typeof(T));
        }
    }
}