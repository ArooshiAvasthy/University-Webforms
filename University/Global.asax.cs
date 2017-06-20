using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace University
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
           
        }

        protected void Application_Error(object sender, EventArgs e)
        {
           
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
        static void RegisterRoutes(RouteCollection routes)
        {
            //routes.MapPageRoute("Contact", "Contact.aspx", "~/Contact.aspx");
            routes.MapPageRoute("Contact", "{locale}/Contact.aspx", "~/Contact.aspx");
            routes.MapPageRoute("DisplayBlog_Page", "Blogs/{BlogId}/{Slug}.aspx", "~/DisplayBlog_Page.aspx");
            
        }
    }
}