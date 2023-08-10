using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.AuditoriumMaster
{
    public class AuditoriumEntity
    {
        public int AuditoriumID { get; set; }

        public string AuditoriumName { get; set; }

       // public int SeatNo { get; set; }
        public bool DeletedFlag { get; set; }
    }
}
