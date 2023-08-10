using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.BlockRowMapping;
using OHSB.IRepository.BlockRowMapping;
using OHSB.IRepository.Factory;

namespace OHSB.Repository.BlockRowMapping
{
    public class BlockRowRepository:RepositoryBase,IBlockMappingRepository
    {
        public BlockRowRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<int> CreateandUpdateRowMap(BlockRowEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@BlockRowID", entity.BlockRowID);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@BlockId", entity.BlockId);
                param.Add("@Row_No", entity.Row_No);
                param.Add("@IsChecked", entity.IsChecked);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "RowBlockInsert");
                var query = "USP_Row_Block_Map";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<BlockRowEntity>> GetBlockDetails(int AuditoriumID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@action", "SelectedAllBlocks");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BlockRowEntity>("USP_Row_Block_Map", param, commandType: CommandType.StoredProcedure).ToList();
                return x;


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<List<BlockRowEntity>> GetRowDetails(int AuditoriumID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@action", "SelectedAllRows");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BlockRowEntity>("USP_Row_Block_Map", param, commandType: CommandType.StoredProcedure).ToList();
                return x;


            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<List<BlockRowEntity>> GetAll(BlockRowEntity slotMapping)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "GetAllMapDetails");
                param.Add("@AuditoriumID", slotMapping.AuditoriumID);
                param.Add("@BlockId ", slotMapping.BlockId);
                param.Add("@Row_No", slotMapping.Row_No);
                param.Add("@BlockRowID", slotMapping.BlockRowID);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var doc = Connection.Query<BlockRowEntity>("USP_Row_Block_Map", param, commandType: CommandType.StoredProcedure).ToList();
                return doc;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteToUpdate(int AuditoriumID, int BlockId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@BlockId", BlockId);
                param.Add("@action", "DeleteToUpdate");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("USP_Row_Block_Map", param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<BlockRowEntity>> GetAllShiftByAAndBId(int AuditoriumID, int BlockId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@BlockId", BlockId);
                param.Add("@action", "getdatabyids");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<BlockRowEntity>("USP_Row_Block_Map", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> Delete(int AuditoriumID, int BlockId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@BlockId", BlockId);
                param.Add("@action", "Delete");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("USP_Row_Block_Map", param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
