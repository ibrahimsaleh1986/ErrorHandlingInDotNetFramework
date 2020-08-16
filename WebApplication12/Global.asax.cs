using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication12
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            HttpException httpException = exception as HttpException;

            Response.Clear();
            Server.ClearError();

            if (httpException == null)
            {
                Response.Redirect("~/Error/Index");
            }
            else
            {
                switch (httpException.GetHttpCode())
                {
                    case 404:
                        Response.Redirect("~/Error/PageNotFound");
                        break;
                    case 500:
                        Response.Redirect("~/Error/ApplicationErrorPage");
                        break;
                    case 403:
                        Response.Redirect("~/Error/Forbidden");
                        break;

                }
            }

            
        }
    }
}
