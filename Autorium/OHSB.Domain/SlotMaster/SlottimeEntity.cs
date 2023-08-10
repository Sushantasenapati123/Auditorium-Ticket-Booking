using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.SlotMaster
{
    public class SlottimeEntity
    {
        public int SlotID { get; set; }
        public string SlotName { get; set; }
        public string Slot_TimeFrom { get; set; }
        public string Slot_TimeTo { get; set; }

        public int AuditoriumID { get; set; }

        public string AuditoriumName { get; set; }
    }
}
