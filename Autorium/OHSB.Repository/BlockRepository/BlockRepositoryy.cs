


using Dapper;
using OHSB.Domain.BlockMaster;
using OHSB.IRepository.Block;
using OHSB.IRepository.Factory;
using OHSB.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Repository.BlockRepository
{
    public class BlockRepositoryy : RepositoryBase, BlockIRepository
    {
        public BlockRepositoryy(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public async Task<int> CreateBlock(BlockMasters entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlockId", entity.BlockId);
                param.Add("@BlockName", entity.BlockName);
                param.Add("@AuditoriumId", entity.AuditoriumId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.BlockId == 0)
                {
                    param.Add("@action", "InsertBlock");
                }
                else
                {
                    param.Add("@action", "UpdateBlock");
                }
                var query = "SP_Block";
                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> Delete(BlockMasters B)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlockId", B.BlockId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "D");
                Connection.Execute("SP_Block", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public async Task<List<BlockMasters>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BlockMasters>("SP_Block", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<BlockMasters> Getbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@BlockId", id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "SP_Block";
                var GetAppById = Connection.Query<BlockMasters>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public async Task<List<BlockMasters>> BindBlock(int AuditoriumId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "BindBlock");
                param.Add("@AuditoriumId", AuditoriumId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BlockMasters>("SP_Block", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
