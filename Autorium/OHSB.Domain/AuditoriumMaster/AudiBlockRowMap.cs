using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.AuditoriumMaster
{
   public class AudiBlockRowMap
    {
        public int Id { get; set; }
        public int AuditoriumId { get; set; }
        public int BlockId { get; set; }
        public int RowId { get; set; }
        [NotMapped]
        public string AuditoriumName { get; set; }
        [NotMapped]
        public string RowName { get; set; }
        [NotMapped]
        public string BlockName { get; set; }
    }
}
