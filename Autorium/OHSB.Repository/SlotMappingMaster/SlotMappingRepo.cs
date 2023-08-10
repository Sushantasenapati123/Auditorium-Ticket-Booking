using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.SlotMapping;
using OHSB.IRepository.Factory;
using OHSB.IRepository.SlotMappingMaster;

namespace OHSB.Repository.SlotMappingMaster
{
    public class SlotMappingRepo : RepositoryBase, ISlotMapping
    {
        public SlotMappingRepo(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public async Task<int> Create(SlotMappingEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SMID", entity.SMID);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@SlotID", entity.SlotID);
                param.Add("@ShowID", entity.ShowID);
                param.Add("@ShowDate", entity.ShowDate);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.SMID == 0)
                {
                    param.Add("@action", "Insert");
                }
                else
                {
                    param.Add("@action", "Update");
                }
                
                var query = "[USP_SlotMapping]";
                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> Delete(int SMID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SMID", SMID);
                param.Add("@action", "Delete");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("USP_SlotMapping", param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> DeleteToUpdate(int SlotID, int ShowID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SlotID", SlotID);
                param.Add("@ShowID", ShowID);
                param.Add("@action", "DeleteToUpdate");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("USP_SlotMapping", param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<SlotMappingEntity>> GetAll(SlotMappingEntity slotMapping)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                //param.Add("@AuditoriumID", slotMapping.AuditoriumID);
                //param.Add("@SlotID ", slotMapping.SlotID);
                //param.Add("@ShowID", slotMapping.ShowID);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var doc = Connection.Query<SlotMappingEntity>("USP_SlotMapping", param, commandType: CommandType.StoredProcedure).ToList();
                return doc;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<SlotMappingEntity>> GetAllShiftBySAndDId(int SlotID, int ShowID)
        {
            try
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@SlotID", SlotID);
                param.Add("@ShowID", ShowID);
                param.Add("@action", "SelectOne");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<SlotMappingEntity>("USP_SlotMapping", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<SlotMappingEntity> SlotTimeByHnSId(int AuditoriumID, int SlotID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@SlotID", SlotID);
                param.Add("@action", "SlotTimeByHnSId");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<SlotMappingEntity>("USP_SlotMapping", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
