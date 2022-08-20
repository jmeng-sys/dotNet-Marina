using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214_Marina.Data;

namespace CPRG214_Marina.App
{
    public partial class DockSlips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DockSelector.DockSelect += DockSelector_DockSelect;
        }

        // display available in a gridview by using DockSelector Contorl
        private void DockSelector_DockSelect(object sender, Controls.DockEventArgs e)
        {
            uxAvailableSlips.DataSource = e.slips;
            DataBind();
        }
    }
}