using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.ShowsMaster
{
    public class ShowEntity
    {
        public int ShowID { get; set; }
        public string ShowName { get; set; }
        public int AuditoriumID { get; set; }
        public string AuditoriumName { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }
        public bool DeletedFlag { get; set; }
        //****************************************
       

    }
}
