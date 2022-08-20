﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CPRG214_Marina.Data;

/// <summary>
/// To test if Marina Entities are connected to the app
/// </summary>
namespace CPRG214_Marina.App
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new MarinaEntities();
            uxDocks.DataSource = db.Docks.ToList();
            uxDocks.DataBind();
        }
    }
}