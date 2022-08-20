using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214_Marina.Data;

namespace CPRG214_Marina.App.Controls
{
    public partial class DockSelector : System.Web.UI.UserControl
    {
        // declare event
        public event DockSelectHandler DockSelect;

        // Dock property so someone can get the dock object
        public Dock dock { get; set; }
        // Bolean property to set AutoPostBack
        public bool AllowPostBack
        {
            get { return uxDocks.AutoPostBack; }
            set { uxDocks.AutoPostBack = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var mgr = new DockManager();
                uxDocks.DataSource = mgr.GetAllListItems();
                uxDocks.DataTextField = "Name";
                uxDocks.DataValueField = "ID";
                uxDocks.DataBind();
            }
        }

        /// <summary>
        /// when select a value in the dropdown list
        /// </summary>
       
        protected void uxDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // the event is fired here
            if (DockSelect != null)
            {
                // get id from the drop down list
                var id = Convert.ToInt32(uxDocks.SelectedValue);

                // call manager class to get course object
                List<Slip> availableSlips = DockManager.GetSlips(id);

                // instantiate the DockEventArgs class

                var arg = new DockEventArgs
                {
                    slips = availableSlips
                };

                DockSelect.Invoke(this, arg);
            }
        }
    }
}