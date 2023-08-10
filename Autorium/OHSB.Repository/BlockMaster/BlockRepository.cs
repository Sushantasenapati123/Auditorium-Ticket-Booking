using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.BlockMaster;
using OHSB.IRepository.BlockMaster;
using OHSB.IRepository.Factory;

namespace OHSB.Repository.BlockMaster
{
    public class BlockRepository : RepositoryBase, IBlockRepo
    {
        public BlockRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<int> CreateandUpdateBlock(BlockEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlockId", entity.BlockId);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@BlockName", entity.BlockName);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.BlockId == 0)
                {
                    param.Add("@action", "InsertBlock");
                }
                else
                {
                    param.Add("@action", "UpdateBlock");
                }

                var query = "Usp_Block_OP";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<int> deleteBlock(BlockEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlockId", p.BlockId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "DeleteBlock");
                Connection.Execute("Usp_Block_OP", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<BlockEntity>> GetAllBlock()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAllBlock");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BlockEntity>("Usp_Block_OP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<BlockEntity> GetBlockbyid(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlockId", id);
                param.Add("@action", "SelectOneBlock");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "Usp_Block_OP";
                var GetblockById = Connection.Query<BlockEntity>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return GetblockById;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
