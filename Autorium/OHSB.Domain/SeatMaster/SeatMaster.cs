using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.Domain.SeatMaster
{
    public class SeatMaster
    {
        public int SeatId { get; set; }
        public string SeatName { get; set; }
        public bool DeletedFlag { get; set; }
        [NotMapped]
        public string RowName { get; set; }
        [NotMapped]
        public string AuditoriumName { get; set; }
        [NotMapped]
        public int AuditoriumId { get; set; }
        [NotMapped]
        public int RowId { get; set; }
        [NotMapped]
        public int BlockId { get; set; }
        [NotMapped]
        public string BlockName { get; set; }
    }
}
