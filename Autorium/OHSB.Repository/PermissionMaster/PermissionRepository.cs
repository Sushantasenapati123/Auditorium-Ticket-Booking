using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.IRepository.Factory;
using OHSB.IRepository.PermissionMaster;
using OHSB.Domain.PermissionMaster;
using Dapper;
using System.Data;
using OHSB.Domain.SubMenuMaster;

namespace OHSB.Repository.PermissionMaster
{
   public class PermissionRepository:RepositoryBase,IPermissionRepo
    {
        public PermissionRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }
        public async Task<List<PermissionEntity>>RollDDL()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "DDLROLL");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var doc = Connection.Query<PermissionEntity>("[USP_PermissionTable]", param, commandType: CommandType.StoredProcedure).ToList();
                return doc;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> PermissionInsert(PermissionEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SubMenuID", entity.SubMenuID);
                param.Add("@RollID", entity.RollID);
                param.Add("@UserId", entity.UserId);
                param.Add("@IsChecked", entity.IsChecked);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "PermissionInsert");
                Connection.Execute("USP_PermissionTable", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> PermissionUpdateToDelete(int RollID, int UserId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RollID", RollID);
                param.Add("@UserId", UserId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "PermissionUpdateToDelete");
                Connection.Execute("USP_PermissionTable", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<SubMenuEntity>> GetSelectedSubMenus(int RollID, int UserId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RollID", RollID);
                param.Add("@UserId", UserId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "GetSelectedSubMenus");
                var x = Connection.Query<SubMenuEntity>("USP_PermissionTable", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<SubMenuEntity>> GetSelectedMenuByDesig(int RollID, int UserId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RollID", RollID);
                param.Add("@UserId", UserId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "GetSelectedMenuByDesig");
                var x = Connection.Query<SubMenuEntity>("USP_PermissionTable", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<SubMenuEntity>> GetSelectedSubMenuByDesig(int RollID, int UserId)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RollID", RollID);
                param.Add("@UserId", UserId);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "GetSelectedSubMenuByDesig");
                var x = Connection.Query<SubMenuEntity>("USP_PermissionTable", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
