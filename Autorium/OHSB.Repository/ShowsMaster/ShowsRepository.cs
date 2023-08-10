using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.ShowsMaster;
using OHSB.IRepository.Factory;
using OHSB.IRepository.ShowsMaster;

namespace OHSB.Repository.ShowsMaster
{
    public class ShowsRepository:RepositoryBase,IShowRepository
    {
        public ShowsRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }
        public async Task<int> insertupdateShow(ShowEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ShowID", entity.ShowID);
                param.Add("@ShowName", entity.ShowName);
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.ShowID == 0)
                {
                    param.Add("@action", "InsertShow");
                }
                else
                {
                    param.Add("@action", "UpdateShow");
                }

                var query = "Usp_ShowMasterOP";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<int> deleteShow(ShowEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@ShowID", p.ShowID);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "DeleteShow");
                Connection.Execute("Usp_ShowMasterOP", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
        public async Task<List<ShowEntity>> GetAllAuditorium()
        {
            try
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "BindAuditorium");
                // Connection.Execute("Usp_ShowMasterOP", param, commandType: CommandType.StoredProcedure);
                var x = Connection.Query<ShowEntity>("Usp_ShowMasterOP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<ShowEntity>> GetAllShowsData()
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@action", "SelectAll");
                var query = "[Usp_ShowMasterOP]";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<ShowEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return Get;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ShowEntity> GetShowsbyid(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ShowID", id);
                param.Add("@action", "SelectOne");
                var query = "[Usp_ShowMasterOP]";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var Get = Connection.Query<ShowEntity>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Get;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       // ******************************************************************
        
    }
}
