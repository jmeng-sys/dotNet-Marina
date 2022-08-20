using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214_Marina.Data;

namespace CPRG214_Marina.App.Secure
{
    public partial class LeaseSlips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CustomerID"] != null)
            {
                var custid = Convert.ToInt32(Session["CustomerID"]);
                uxCustID.Text = custid.ToString();
                var leases = DockManager.GetLeases(custid);
                uxLeasedSlips.DataSource = leases;
                DataBind();
            }
            else
            {
                var db = new MarinaEntities();
                var allLeases = db.Leases.ToList();
                uxLeasedSlips.DataSource = allLeases;
                DataBind();
            }
        }

        /// <summary>
        /// when a customer clicks Confirm button
        /// </summary>

        protected void uxConfirm_Click(object sender, EventArgs e)
        {
            
            var custid = Convert.ToInt32(Session["CustomerID"]);
            

            var lease = new Lease
            {
                SlipID = Convert.ToInt32(uxSelectedSlip.Text),
                CustomerID = custid
            };
            AuthenticationManager.AddLease(lease);
            // after the customer lease a slip, it will go back to display updated available slips
            Response.Redirect("~/DockSlips"); 
        }
    }
}