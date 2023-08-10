using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.BlockMaster
{
    public class BlockMasters
    {
        public int AuditoriumId { get; set; }
        public string BlockName { get; set; }
        public int BlockId { get; set; }
        [NotMapped]
        public string AuditoriumName { get; set; }
    }
}
