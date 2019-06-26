using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BOL;
using DAL;
using BLL;

namespace crudfrontend
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            List<Student> students = new List<Student>();
            students = StudentManager.GetAll();

            //RepoManager.GetAllProducts();
            this.Application["students"] = students;
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
