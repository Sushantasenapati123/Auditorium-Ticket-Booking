using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.Row_SeatMaster;
using OHSB.IRepository.Factory;
using OHSB.IRepository.Row_SeatMaster;

namespace OHSB.Repository.Row_SeatMaster
{
    public class RowSeatRepository:RepositoryBase,IRowSeatRepo
    {
        public RowSeatRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public async Task<int> Create(RowSeatEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditseatID", entity.AuditseatID);
                param.Add("@Row_No", entity.Row_No);
                param.Add("@Number", entity.Number);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.AuditseatID == 0)
                {
                    param.Add("@action", "InsertRowDetails");
                }
                else
                {
                    param.Add("@action", "UpdateRowDetails");
                }

                var query = "Usp_AuditoriumOP";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<RowSeatEntity>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAllData");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<RowSeatEntity>("Usp_AuditoriumOP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<RowSeatEntity> Getbyid(int AuditseatID)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@AuditseatID", AuditseatID);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "Usp_AuditoriumOP";
                var GetAppById = Connection.Query<RowSeatEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        public async Task<int> delete(RowSeatEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@AuditseatID", p.AuditseatID);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "Delete");
                Connection.Execute("[Usp_AuditoriumOP]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
        public async Task<List<RowSeatEntity>> BindRows()
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@action", "BindRow");
                var query = "Usp_AuditoriumOP";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<RowSeatEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return Get;


            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public async Task<List<RowSeatEntity>> BindAuditorium()
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@action", "BindAuditorium");
                var query = "Usp_AuditoriumOP";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<RowSeatEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return Get;


            }
            catch (Exception ex)
            {
                return null;

            }
        }
    }
}
