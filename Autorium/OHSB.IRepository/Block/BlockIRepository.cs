using OHSB.Domain.BlockMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.IRepository.Block
{
    public interface BlockIRepository
    {
        Task<int> CreateBlock(BlockMasters entity);
        Task<List<BlockMasters>> GetAll();
        Task<int> Delete(BlockMasters p);
        Task<BlockMasters> Getbyid(int id);
        Task<List<BlockMasters>> BindBlock(int AuditoriumId);
    }
}
