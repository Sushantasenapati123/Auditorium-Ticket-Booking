using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.ScreenMap
{
   public class ScreenMapEntity
    {
        public int AuditoriumID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
     
        public decimal Amount { get; set; }
        public string AuditoriumName { get; set; }
        public string Photo { get; set; }
        public int ShowId { get; set; }
        public string ShowName { get; set; }
        public string ShowType { get; set; }
        public string ShowTimeFrom { get; set; }
        public string ShowTimeTo { get; set; }
        public string ShowDate { get; set; }
        public int id { get; set; }
        public int ScreenMapId { get; set; }
    }
    
    
}
