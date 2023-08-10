using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.SeatMaster
{
    public class SeatEntity
    {
        // SeatId,AuditoriumID,Row_No,SeatCapacity,DeletedFlag
        public int SeatId { get; set; }
        public int AuditoriumID { get; set; }
        public string AuditoriumName { get; set; }
        public int Row_No { get; set; }
        public string RowDesc { get; set; }
        public int SeatCapacity { get; set; }
        public bool DeletedFlag { get; set; }
        public int SeatNos { get; set; }
        public string SeatNo { get; set; }
        public List<SeatNumbers> SeatNumber { get; set; }

    }
    public class SeatNumbers
    {
        public int SeatNoId { get; set; }
        public int SeatId { get; set; }
        public int SeatNos { get; set; }
        public int AuditoriumID { get; set; }
        public int Row_No { get; set; }
    }
}
