using Auditorium.Domain.ShowSelect;

using Auditorium.IRepository.ShowSelectIRepo;
using Dapper;
using OHSB.IRepository.Factory;
using OHSB.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.Repository.ShowSelectMasterRepository
{
    public class ShowSelectMasterRepository : RepositoryBase, ShowSelectIRepository
    {
        public ShowSelectMasterRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<int> Create(ShowSelect entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", entity.Id);
                param.Add("@AuditoriumId", entity.AuditoriumId);
                param.Add("@ShowId", entity.ShowId);
                param.Add("@ShowType", entity.ShowType);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.Id == 0)
                {
                    param.Add("@action", "Insert");
                }
                else
                {
                    param.Add("@action", "Update");
                }
                var query = "SP_ShowsSelect";
                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> Delete(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Id);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "Delete");
                Connection.Execute("SP_ShowsSelect", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public async Task<List<ShowSelect>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<ShowSelect>("SP_ShowsSelect", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ShowSelect> Getbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@Id", id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "SP_ShowsSelect";
                var GetAppById = Connection.Query<ShowSelect>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }
        }
    }
}
