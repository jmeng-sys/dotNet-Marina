using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPRG214_Marina.App
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Context is property of Page class, type HttpContext
            // check if Context.User.Identity.IsAuthenticated (set innerhtml of uxLogin and uxWelcome)
            if (Context.User.Identity.IsAuthenticated)
            {
                uxWelcome.InnerText = $"Welcome{Context.User.Identity.Name}";
                uxLogin.InnerHtml = "<span class='fa fa-sign-out-alt'>";
            }
            else
            {
                uxLogin.InnerHtml = "<span class='fa fa-sign-in-alt'>";
                uxWelcome.InnerHtml = string.Empty;
            }

        }

        protected void HandleLoginClick(object sender, EventArgs e)
        {
            // check if Context.User.Identity.IsAuthenticated (set innerhtml of uxLogin and uxWelcome)
            if (Context.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
                Session.Clear();
                Response.Redirect("~/");
            }
            else
            {
                Response.Redirect("~/Login");
            }
            
        }

        //protected void HandleRegisterClick(object sender, EventArgs e)
        //{
           
        //        Response.Redirect("~/Registration");
            
        //    //Response.Write("<script>alert('Login Clicked');</script>");
        //}
    }   
}