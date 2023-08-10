using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.BlockRowMapping;

namespace OHSB.IRepository.BlockRowMapping
{
  public  interface IBlockMappingRepository
    {
        Task<int> CreateandUpdateRowMap(BlockRowEntity entity);
        Task<List<BlockRowEntity>> GetBlockDetails(int AuditoriumID);
        Task<List<BlockRowEntity>> GetRowDetails(int AuditoriumID);
        Task<List<BlockRowEntity>> GetAll(BlockRowEntity slotMapping);
        Task<int> DeleteToUpdate(int AuditoriumID, int DoctorId);
        Task<List<BlockRowEntity>> GetAllShiftByAAndBId(int AuditoriumID, int BlockId);
        Task<int> Delete(int AuditoriumID, int BlockId);
    }
}
