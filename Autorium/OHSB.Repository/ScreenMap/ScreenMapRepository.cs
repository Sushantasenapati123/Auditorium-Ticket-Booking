using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.IRepository.ScreenMap;
using OHSB.Domain.ScreenMap;
using OHSB.IRepository.Factory;
using Dapper;
using System.Data;

namespace OHSB.Repository.ScreenMap
{
   public class ScreenMapRepository: RepositoryBase,IScreenMap
    {
        public ScreenMapRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }

        public async Task<int> insertupdate(ScreenMapEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ScreenMapId", entity.ScreenMapId);
                param.Add("@ShowId", entity.ShowId);
              
                param.Add("@AuditoriumID", entity.AuditoriumID);
                param.Add("@ShowTimeFrom", entity.ShowTimeFrom);
                param.Add("@ShowTimeTo", entity.ShowTimeTo);
                param.Add("@id", entity.id);
                param.Add("@ShowType", entity.ShowType);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.ScreenMapId == 0)
                {
                    param.Add("@action", "Insert");
                }
                else
                {
                    param.Add("@action", "UpdateShow");
                }

                var query = "Usp_Bk_ScreenMap_OP";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<ScreenMapEntity>> GetAllShowType()
        {
            try
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "BindShowType");
                
                var x = Connection.Query<ScreenMapEntity>("Usp_Bk_ScreenMap_OP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<ScreenMapEntity>> GetAllShow()
        {
            try
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "BindShow");

                var x = Connection.Query<ScreenMapEntity>("Usp_Bk_ScreenMap_OP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<ScreenMapEntity>> GetAllData()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                var query = "Usp_Bk_ScreenMap_OP";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<ScreenMapEntity>(query, param, commandType: CommandType.StoredProcedure).AsList();
                return Get;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<ScreenMapEntity>> GetAuditoriumAndTimebyShowid(int showid)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ShowId", showid);
                param.Add("@action", "GetAuditoriumAndTimebyShowid");
                var query = "Usp_Bk_ScreenMap_OP";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<ScreenMapEntity>(query, param, commandType: CommandType.StoredProcedure).AsList();
                return Get;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<ScreenMapEntity>> findallFilm()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "findallFilm");
                var query = "Usp_Bk_ScreenMap_OP";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<ScreenMapEntity>(query, param, commandType: CommandType.StoredProcedure).AsList();
                return Get;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public async Task<ScreenMapEntity> GetbyShowid(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ShowId", id);
                param.Add("@action", "GetbyShowid");
                var query = "[Usp_Bk_ScreenMap_OP]";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var Get = Connection.Query<ScreenMapEntity>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Get;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ScreenMapEntity> GetShowsbyid(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ScreenMapId", id);
                param.Add("@action", "SelectOne");
                var query = "[Usp_Bk_ScreenMap_OP]";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var Get = Connection.Query<ScreenMapEntity>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Get;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> deleteShow(ScreenMapEntity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@ScreenMapId", p.ScreenMapId);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "DeleteShow");
                Connection.Execute("Usp_Bk_ScreenMap_OP", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public async Task<ScreenMapEntity> GetShowsTimebyid( int ShowId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                //param.Add("@id", id);
                param.Add("@ShowId", ShowId);
                param.Add("@action", "BindShowtime");
                var query = "[Usp_Bk_ScreenMap_OP]";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var Get = Connection.Query<ScreenMapEntity>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Get;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
