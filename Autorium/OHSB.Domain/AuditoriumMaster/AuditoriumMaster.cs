using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.AuditoriumMaster
{
    public class AuditoriumMaster
    {
        public int Id { get; set; }
        public int AuditoriumId { get; set; }
        public string AuditoriumName { get; set; }
        public string AuditoriumDesc { get; set; }
        public bool DeletedFlag { get; set; }

    }
}
