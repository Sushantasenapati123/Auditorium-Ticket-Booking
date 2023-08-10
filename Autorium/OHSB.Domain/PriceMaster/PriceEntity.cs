using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.PriceMaster
{
    public class PriceEntity
    {
        public int PriceId { get; set; }
        public int AuditoriumID { get; set; }
        public string AuditoriumName { get; set; }
        public int BlockId { get; set; }
        public string Price { get; set; }
        public string RowDesc { get; set; }
        public string BlockName { get; set; }
        public int  Row_No { get; set; }
    }
}
