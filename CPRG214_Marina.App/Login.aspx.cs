using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214_Marina.Data;

namespace CPRG214_Marina.App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// when the user click the login button
        /// </summary>

        protected void uxAuthenticate_Click(object sender, EventArgs e)
        {
            // pass the credentials to the AuthenticationManager
            var customer = AuthenticationManager.Authenticate(uxFirstName.Text, uxLastName.Text);

            // return to Login page if the customer does not match any record
            if (customer == null)
            {
                uxError.Text = "Customer does not exist";
                Response.Redirect("~/login");
            }

            // add customer id to session
            Session.Add("CustomerID", customer.ID);
            uxError.Text = "";

            //redirect
            FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);
        }
    }
}