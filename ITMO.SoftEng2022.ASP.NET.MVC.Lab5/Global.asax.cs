using System.Data.Entity; // п.4
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MvcCreditApp1.Models; // п.4


namespace MvcCreditApp1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new CreditsDbInitializer()); // п.3 генерация б.д.
        }
    }
}
