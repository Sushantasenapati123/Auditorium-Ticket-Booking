using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.SlotMapping;

namespace OHSB.IRepository.SlotMappingMaster
{
   public interface ISlotMapping
    {
        Task<List<SlotMappingEntity>> GetAll(SlotMappingEntity slotMapping);
        Task<List<SlotMappingEntity>> GetAllShiftBySAndDId(int SlotID, int ShowID);
        Task<int> Create(SlotMappingEntity entity);
        Task<int> Delete(int SMID);
        Task<SlotMappingEntity> SlotTimeByHnSId(int AuditoriumID, int SlotID);
        Task<int> DeleteToUpdate(int SlotID, int ShowID);
    }
}
