using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.Row_SeatMaster
{
    public class RowSeatEntity
    {
        public int AuditoriumID { get; set; }
        public string AuditoriumName { get; set; }
        public int AuditseatID { get; set; }
        public int Row_No { get; set; }
        public string Number { get; set; }
        public string  Row_Name { get; set; }
    }
}
