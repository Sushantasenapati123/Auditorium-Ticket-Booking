using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OHSB.IRepository.Factory;
using OHSB.IRepository.Show_Master;
using OHSB.Domain.Show_Master;
namespace OHSB.Repository.Show_Master
{
    public class Show_MasterRepository:RepositoryBase,IShow_Master
    {
        public Show_MasterRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }
        public async Task<List<Show_Entity>> GetAllShowType()
        {
            try
            {

                DynamicParameters param = new DynamicParameters();
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "BindShowType");
                var x = Connection.Query<Show_Entity>("Usp_Bk_ShowMasterOP", param, commandType: CommandType.StoredProcedure).ToList();
                return x;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<int> insertupdateShow(Show_Entity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ShowId", entity.ShowId);
                param.Add("@ShowName", entity.ShowName);
                param.Add("@id", entity.id);
                param.Add("@ShowTimeFrom", entity.ShowTimeFrom);
                param.Add("@ShowTimeTo", entity.ShowTimeTo);
                param.Add("@Photo", entity.Photo);
                param.Add("@ShowDate", entity.ShowDate);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.ShowId == 0)
                {
                    param.Add("@action", "InsertShow");
                }
                else
                {
                    param.Add("@action", "UpdateShow");
                }

                var query = "Usp_Bk_ShowMasterOP";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<List<Show_Entity>> GetAllShowsData()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                var query = "Usp_Bk_ShowMasterOP";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var Get = Connection.Query<Show_Entity>(query, param, commandType: CommandType.StoredProcedure).AsList();
                return Get;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<Show_Entity> GetShowsbyid(int id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ShowId", id);
                param.Add("@action", "SelectOne");
                var query = "[Usp_Bk_ShowMasterOP]";
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var Get = Connection.Query<Show_Entity>(query, param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return Get;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> deleteShow(Show_Entity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@ShowId", p.ShowId);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "DeleteShow");
                Connection.Execute("Usp_Bk_ShowMasterOP", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }
    }
}
