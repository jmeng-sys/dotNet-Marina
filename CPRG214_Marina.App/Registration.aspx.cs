using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214_Marina.Data;

namespace CPRG214_Marina.App
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// when the user clicks the register button
        /// </summary>

        protected void uxRegistration_Click(object sender, EventArgs e)
        {
            // define a new customer object from input
            var customer = new Customer
            {
                FirstName = uxFirstName.Text,
                LastName = uxLastName.Text,
                Phone = uxPhone.Text,
                City = uxCity.Text
            };

            // test if the customer is already in database, return to the registration page after all
            var testCust = AuthenticationManager.Authenticate(uxFirstName.Text, uxLastName.Text);

            if (testCust == null)
            {
                AuthenticationManager.AddCustomer(customer);
            }
            Response.Redirect("~/Registration");
        }
    }
}