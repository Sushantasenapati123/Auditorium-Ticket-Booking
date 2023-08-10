using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.SlotMaster;

namespace OHSB.IRepository.SlotMaster
{
    public interface ISlotRepository
    {
        Task<int> insert(SlottimeEntity p);
        Task<int> delete(int p);
        Task<List<SlottimeEntity>> GetAllSlot(SlottimeEntity p);
        Task<SlottimeEntity> GetbyidSlot(int id);
        Task<List<SlottimeEntity>> AuditoriumDDL();
        Task<List<SlottimeEntity>> SlotAIdDDL(int AuditoriumID);

    }
}
