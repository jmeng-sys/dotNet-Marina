using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214_Marina.Data
{
    public class DockManager
    {
        public IList GetAllListItems()
        {
            var db = new MarinaEntities();
            var docks = db.Docks.Select(dcs => new { ID = dcs.ID, Name = dcs.Name }).ToList();
            return docks;
        }

        public List<Dock> GetAllDocks()
        {
            var db = new MarinaEntities();
            var docks = db.Docks.ToList();
            return docks;
        }

      
        
        public static Dock FindDock(int id)
        {
            var db = new MarinaEntities();
            var dock = db.Docks.SingleOrDefault(d => d.ID == id);
            return dock;
        }

        public static List<Slip> GetSlips(int selectedDockId)
        {
            var db = new MarinaEntities();

            var availableSlips = db.Slips.Where(s => s.Leases.Count == 0 && s.DockID == selectedDockId).ToList();
            return availableSlips;
        }

        public static List<Lease> GetLeases(int custID)
        {
            var db = new MarinaEntities();

            var LeasedSlips = db.Leases.Where(l => l.CustomerID == custID).ToList();
            return LeasedSlips;
        }
    }
}
