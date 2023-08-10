using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.Domain.ShowSelect
{
    public class ShowSelect
    {
        public int Id { get; set; }
        public int AuditoriumId { get; set; }
        public int ShowId { get; set; }
        public string ShowType { get; set; }
        [NotMapped]
        public String AuditoriumName { get; set; }
        public String ShowName { get; set; }
    }
}
