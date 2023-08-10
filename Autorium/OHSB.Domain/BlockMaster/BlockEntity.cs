using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.BlockMaster
{
    public class BlockEntity
    {
        public int BlockId { get; set; }
        public int AuditoriumID { get; set; }
        public string AuditoriumName { get; set; }
        public string BlockName { get; set; }
        public bool DeletedFlag { get; set; }
    }
}
