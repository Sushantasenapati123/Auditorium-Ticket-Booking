using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.RowMaster
{
    public class RowEntity
    {
        public int Seat_Id { get; set; }
        public string Seat_No { get; set; }
        public int Row_No { get; set; }
        public string Row_Name { get; set; }
        public string RowDesc { get; set; }
        public bool DeletedFlag { get; set; }
    }
}
