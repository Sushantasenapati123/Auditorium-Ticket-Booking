
using Auditorium.IRepository.Auditorium;

using Dapper;
using OHSB.Domain.AuditoriumMaster;
using OHSB.IRepository.Factory;
using OHSB.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.Repository.AuditoriumRepository
{
    public class AuditoriumRepo : RepositoryBase, AuditoriumIRepository
    {
        public AuditoriumRepo(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }
        
        public async Task<int> CreateAuditorium(AuditoriumMaster entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumId", entity.AuditoriumId);
                param.Add("@AuditoriumName", entity.AuditoriumName);
                param.Add("@AuditoriumDesc", entity.AuditoriumDesc);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.AuditoriumId == 0)
                {
                    param.Add("@action", "InsertAuditorium");
                }
                else
                {
                    param.Add("@action", "UpdateAuditorium");
                }
                var query = "SP_Auditorium";
                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> delete(AuditoriumMaster p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@AuditoriumId", p.AuditoriumId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "D");
                Connection.Execute("SP_Auditorium", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        public async Task<List<AuditoriumMaster>> GetAll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<AuditoriumMaster>("SP_Auditorium", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<AuditoriumMaster> Getbyid(int id)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@AuditoriumId", id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "SP_Auditorium";
                var GetAppById = Connection.Query<AuditoriumMaster>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }
        }
        public async Task<List<AuditoriumMaster>> AuditoriumBind()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "BindAuditorium");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<AuditoriumMaster>("SP_Auditorium", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //For Block DDl and Row CheckBox---------------------------------------------------------------------------------------------
        public async Task<int> InsertBlockAndRow(int Id, int AuditoriumId, int BlockId, int[] RowId)
        {
            try
            {
                int result = 0;
                foreach (int row in RowId)
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Id", Id);
                    param.Add("@AuditoriumId", AuditoriumId);
                    param.Add("@BlockId", BlockId);
                    param.Add("@RowId", row);
                    param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                    if (Id == 0)
                    {
                        param.Add("@action", "InsertBlockAndRow");
                    }
                    else
                    {
                        param.Add("@action", "UpdateBlockAndRow");
                    }
                    Connection.Execute("SP_BlockAndRow", param, commandType: CommandType.StoredProcedure);
                    result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<AudiBlockRowMap>> ShowBlockAndRowName()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "ShowNames");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<AudiBlockRowMap>("SP_BlockAndRow", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<AudiBlockRowMap> GetOnebyid(int Id)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@Id", Id);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "SP_BlockAndRow";
                var GetAppById = Connection.Query<AudiBlockRowMap>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

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
                Connection.Execute("SP_BlockAndRow", param, commandType: CommandType.StoredProcedure);
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


    

