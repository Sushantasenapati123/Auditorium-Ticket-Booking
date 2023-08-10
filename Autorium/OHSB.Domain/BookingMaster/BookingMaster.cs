using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.Domain.BookingMaster
{
    public class BookingMaster
    {
        public int Id { get; set; }
        public string[] BookTickets { get; set; }
        public DateTime BookingDate { get; set; }
        public string UserId { get; set; }
        public int AuditoriumId { get; set; }
        public int BlockId { get; set; }
        public int RowId { get; set; }
        public int SeatId { get; set; }
  
        [NotMapped]
        public string UserName { get; set; }
        [NotMapped]
        public string AuditoriumName { get; set; }
        [NotMapped]
        public string BlockName { get; set; }
        [NotMapped]
        public string RowName { get; set; }
        [NotMapped]
        public string SeatName { get; set; }
    }
}
