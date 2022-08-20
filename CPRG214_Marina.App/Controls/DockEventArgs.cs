using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CPRG214_Marina.Data;

namespace CPRG214_Marina.App.Controls
{
    public class DockEventArgs : EventArgs
    {
        public List<Slip> slips{ get; set; }

    }
}