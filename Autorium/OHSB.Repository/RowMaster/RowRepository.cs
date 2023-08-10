using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.IRepository.Factory;
using OHSB.IRepository.RowMaster;
using OHSB.Domain.RowMaster;

namespace OHSB.Repository.RowMaster
{
    public class RowRepository:RepositoryBase,IRowRepository
    {
        public RowRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public async Task<int> InsertRow(RowEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Row_No", entity.Row_No);
                param.Add("@Row_Name", entity.Row_Name);
                param.Add("@RowDesc", entity.RowDesc);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.Row_No == 0)
                {
                    param.Add("@action", "InsertRow");
                }
                else
                {
                    param.Add("@action", "UpdateRow");
                }

                var query = "USP_RowDetails";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<RowEntity> GetRowbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@Row_No", id);
                ObjParm.Add("@action", "SelectOneRow");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_RowDetails";
                var GetAppById = Connection.Query<RowEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        public async Task<int> deleteRow(RowEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@Row_No", p.Row_No);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "DeleteRow");
                Connection.Execute("[USP_RowDetails]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
        public async Task<List<RowEntity>> GetAllRows(RowEntity p)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@action", "SelectAllRow");
                var query = "USP_RowDetails";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<RowEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return Get;


            }
            catch (Exception ex)
            {
                return null;

            }
        }
        //seatno deatails
        public async Task<int> InsertSeat(RowEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Seat_Id", entity.Seat_Id);
                param.Add("@Row_No", entity.Row_No);
                param.Add("@Seat_No", entity.Seat_No);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.Seat_Id == 0)
                {
                    param.Add("@action", "InsertSeat");
                }
                else
                {
                    param.Add("@action", "UpdateSeat");
                }

                var query = "USP_RowDetails";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<RowEntity> GetSeatbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@Seat_Id", id);
                ObjParm.Add("@action", "SelectOneSeat");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_RowDetails";
                var GetAppById = Connection.Query<RowEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        public async Task<int> deleteSeat(RowEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@Seat_Id", p.Seat_Id);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "DeleteSeat");
                Connection.Execute("[USP_RowDetails]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
        public async Task<List<RowEntity>> GetAllSeats(RowEntity p)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@action", "SelectAllSeat");
                var query = "USP_RowDetails";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<RowEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return Get;


            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public async Task<List<RowEntity>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "DropDownBindRows");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<RowEntity>("USP_RowDetails", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
