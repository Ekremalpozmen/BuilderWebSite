using BuilderWebSite.Data;

using BuilderWebSite.LightInject;
using BuilderWebSite.LightInject.Mvc;
using System.Net;
using System.Web.Mvc;
using System.Web.Routing;

namespace BuilderWebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = new LightInject.ServiceContainer();
            container.RegisterControllers();
            container.Register(typeof(BuilderWebSiteEntities), new PerRequestLifeTime());
            container.Register<Infrastructure.ICacheService, Infrastructure.Web.InMemoryCache>(new PerRequestLifeTime());
            System.Net.ServicePointManager.SecurityProtocol |=
                SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            container.Register(typeof(Services.WebSite.SliderService), new PerRequestLifeTime());
            container.Register(typeof(Services.WebSite.OurService), new PerRequestLifeTime());
            container.Register(typeof(Services.WebSite.ContactUsService), new PerRequestLifeTime());
            container.EnableMvc();
        }
    }
}
