using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.IRepository.SlotMaster;
using OHSB.Domain.SlotMaster;
using OHSB.IRepository.Factory;
using Dapper;
using System.Data;

namespace OHSB.Repository.SlotMaster
{
    public class SlotRepository : RepositoryBase, ISlotRepository
    {
        public SlotRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
       
        public async Task<List<SlottimeEntity>> AuditoriumDDL()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "GetAllSlotByAuditorium");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<SlottimeEntity>("USP_Slot_Master", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> delete(int p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SlotID", p);
                param.Add("@action", "Delete");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("[USP_Slot_Master]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public async Task<List<SlottimeEntity>> GetAllSlot(SlottimeEntity p)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@action", "Alldata");
                ObjParm.Add("@AuditoriumID", p.AuditoriumID);
                var query = "USP_Slot_Master";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var GetAppById = Connection.Query<SlottimeEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();

                return GetAppById;

            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public async Task<SlottimeEntity> GetbyidSlot(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@SlotID", id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_Slot_Master";
                var GetAppById = Connection.Query<SlottimeEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task<int> insert(SlottimeEntity om)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SlotID", om.SlotID);
                param.Add("@SlotName", om.SlotName);
                param.Add("@AuditoriumID", om.AuditoriumID);
                param.Add("@Slot_TimeFrom", om.Slot_TimeFrom);
                param.Add("@Slot_TimeTo", om.Slot_TimeTo);
                param.Add("@action", "InsertUpdate");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("[USP_Slot_Master]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public async Task<List<SlottimeEntity>> SlotAIdDDL(int AuditoriumID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "DDLSlot");
                param.Add("@AuditoriumID", AuditoriumID);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var doc = Connection.Query<SlottimeEntity>("[USP_SlotMapping]", param, commandType: CommandType.StoredProcedure).ToList();
                return doc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
