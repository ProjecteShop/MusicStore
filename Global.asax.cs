
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MusicStore.DAL.MusicStore;
using MusicStore.DAL.Repository;
using MusicStore.NinjectBinding.Binders;


namespace MusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            MusicStore.RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer<DbContext>(null);
            ModelBinders.Binders.Add(typeof(Cart), new CartBinder());

        }
        
    }
}
