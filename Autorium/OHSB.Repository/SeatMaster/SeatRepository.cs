using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.SeatMaster;
using OHSB.IRepository.Factory;
using OHSB.IRepository.SeatMaster;

namespace OHSB.Repository.SeatMaster
{
    public class SeatRepository : RepositoryBase, ISeatRepo
    {
        public SeatRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<int> deleteSeat(SeatEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SeatId", p.SeatId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "DeleteseatInfo");
                Connection.Execute("USP_BKG_SeatOP", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<SeatEntity>> GetAllSeat()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAllseatInfo");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<SeatEntity>("USP_BKG_SeatOP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> InsertSeat(SeatEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SeatId", entity.SeatId);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@Row_No", entity.Row_No);
                param.Add("@SeatCapacity", entity.SeatCapacity);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.SeatId == 0)
                {
                    param.Add("@action", "InsertSeat");
                }
                else
                {
                    param.Add("@action", "UpdateSeat");
                }

                var query = "[USP_BKG_SeatOP]";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public async Task<SeatEntity> GetSeatbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@SeatId", id);
                ObjParm.Add("@action", "SelectOneseatInfo");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_BKG_SeatOP";
                var GetAppById = Connection.Query<SeatEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return GetAppById;
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task<SeatEntity> GetseatCapacitybyid(int SeatId)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@SeatId", SeatId);
                ObjParm.Add("@action", "SeatCapcity");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_BKG_SeatOP";
                var GetAppById = Connection.Query<SeatEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return GetAppById;
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        //public async Task<int> insertSeatnos(int z,int y)
        //{
        //    try
        //    {
        //        DynamicParameters param = new DynamicParameters();
        //        param.Add("@SeatId", z);
        //        param.Add("@SeatNos", y);
        //        param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
        //        param.Add("@action", "InsertseatNo");
        //        var query = "[USP_BKG_SeatOP]";
        //        Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
        //        int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
        //        return x;


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        public async Task<int> insertSeatnos(SeatNumbers entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SeatId", entity.SeatId);
                param.Add("@SeatNos", entity.SeatNos);
                param.Add("@Row_No", entity.Row_No);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "InsertseatNo");
                var query = "[USP_BKG_SeatOP]";
                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<SeatEntity>> GetSeatdetailsbyid(int id)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@AuditoriumID", id);
                ObjParm.Add("@action", "getdetailsofseats");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_BKG_SeatOP";
                var GetAppById = Connection.Query<SeatEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).ToList();
                return GetAppById;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<int> deleteSeatNos(int p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SeatId", p);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "DeleteToUpdateSeatnos");
                Connection.Execute("USP_BKG_SeatOP", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<List<SeatEntity>> checkrowandauditorium(SeatEntity rows)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@AuditoriumID", rows.AuditoriumID);
                ObjParm.Add("@Row_No", rows.Row_No);
                ObjParm.Add("@action", "countrow");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_BKG_SeatOP";
                var GetAppById = Connection.Query<SeatEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).ToList();
                return GetAppById;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<List<SeatNumbers>> GetSeatNosbyid(int id)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@AuditoriumID", id);
                ObjParm.Add("@action", "AllSeat");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_BKG_SeatOP";
                var GetAppById = Connection.Query<SeatNumbers>(query, ObjParm, commandType: CommandType.StoredProcedure).ToList();
                return GetAppById;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}




