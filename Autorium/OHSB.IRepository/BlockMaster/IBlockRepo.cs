using OHSB.Domain.BlockMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.IRepository.BlockMaster
{
   public interface IBlockRepo
    {
        Task<int> CreateandUpdateBlock(BlockEntity entity);
        Task<int> deleteBlock(BlockEntity p);
        Task<List<BlockEntity>> GetAllBlock();
        Task<BlockEntity> GetBlockbyid(int id);
    }
}
