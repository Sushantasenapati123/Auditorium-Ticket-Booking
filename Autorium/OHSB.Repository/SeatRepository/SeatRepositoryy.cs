using Auditorium.Domain.SeatMaster;

using Auditorium.IRepository.Seat;
using Dapper;
using OHSB.IRepository.Factory;
using OHSB.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.Repository.SeatRepository
{
    public class SeatRepositoryy:RepositoryBase,SeatIRepository
    {
        public SeatRepositoryy(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        public async Task<int> CreateSeat(SeatMaster entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SeatId", entity.SeatId);
                param.Add("@AuditoriumId", entity.AuditoriumId);
                param.Add("@RowId", entity.RowId);
                param.Add("@SeatName", entity.SeatName);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.SeatId == 0)
                {
                    param.Add("@action", "InsertSeat");
                }
                else
                {
                    param.Add("@action", "UpdateSeat");
                }
                var query = "SP_Seat";
                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<int> delete(SeatMaster p)
        {
            
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@SeatId", p.SeatId);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "D");
                Connection.Execute("SP_Seat", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public async Task<List<SeatMaster>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<SeatMaster>("SP_Seat", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<SeatMaster> Getbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@SeatId", id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "SP_Seat";
                var GetAppById = Connection.Query<SeatMaster>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public async Task<List<SeatMaster>> SelectAllForBlock(int AuditoriumId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumId", AuditoriumId);
                param.Add("@action", "SelectAllForBlock");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<SeatMaster>("SP_Seat", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
