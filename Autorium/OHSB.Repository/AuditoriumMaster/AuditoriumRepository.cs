using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.AuditoriumMaster;
using OHSB.IRepository.AuditoriumIRepository;
using OHSB.IRepository.Factory;

namespace OHSB.Repository.AuditoriumMaster
{
    public class AuditoriumRepository:RepositoryBase,IAuditoriumRepo
    {
        public AuditoriumRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<int> CreateAuditorium(AuditoriumEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@AuditoriumName", entity.AuditoriumName);
                //param.Add("@SeatNo", entity.SeatNo);              
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.AuditoriumID == 0)
                {
                    param.Add("@action", "InsertAuditorium");
                }
                else
                {
                    param.Add("@action", "UpdateAuditorium");
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

        public async Task<int> delete(AuditoriumEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@AuditoriumID", p.AuditoriumID);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "D");
                Connection.Execute("[Usp_AuditoriumOP]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public async Task<List<AuditoriumEntity>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<AuditoriumEntity>("Usp_AuditoriumOP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<AuditoriumEntity> Getbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@AuditoriumID", id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "Usp_AuditoriumOP";
                var GetAppById = Connection.Query<AuditoriumEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }

        }
    }
}
