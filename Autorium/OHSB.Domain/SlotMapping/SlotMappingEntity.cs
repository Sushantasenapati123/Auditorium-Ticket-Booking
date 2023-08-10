using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.SlotMapping
{
    public class SlotMappingEntity
    {
        public int SMID { get; set; }
        public int AuditoriumID { get; set; }
        public string AuditoriumName { get; set; }
        public int SlotID { get; set; }
        public string SlotName { get; set; }
        public int ShowID { get; set; }
        public string ShowName { get; set; }
        public string ShowDate { get; set; }
        public string Slot_TimeFrom { get; set; }
        public string Slot_TimeTo { get; set; }
        public int SeatNo { get; set; }
    }
}
