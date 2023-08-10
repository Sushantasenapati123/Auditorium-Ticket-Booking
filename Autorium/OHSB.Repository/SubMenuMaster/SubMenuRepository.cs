using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.IRepository.SubMenuMaster;
using OHSB.Domain.MenuMaster;
using OHSB.Domain.SubMenuMaster;
using OHSB.IRepository.Factory;
using Dapper;
using System.Data;

namespace OHSB.Repository.SubMenuMaster
{
    public class SubMenuRepository:RepositoryBase,ISubMenuRepo
    {
        public SubMenuRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }
        public async Task<int> SubMenuDelete(int SubMenuID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SubMenuId", SubMenuID);
                param.Add("@action", "SubMenuDelete");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("USP_SubMenuTable", param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<List<MenuEntity>> GetAllMenu()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "MenuSelectAll");
                var x = Connection.Query<MenuEntity>("[USP_MenuTable]", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> SubMenuInsertAndUpdate(SubMenuEntity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SubMenuID", entity.SubMenuID);
                param.Add("@SubMenuName", entity.SubMenuName);
                param.Add("@SubMenuURL", entity.SubMenuURL);
                param.Add("@MenuID", entity.MenuID);
                param.Add("@SlNo", entity.SlNo);
                param.Add("@SubMenuDescription", entity.SubMenuDescription);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.SubMenuID == 0)
                {
                    param.Add("@action", "SubMenuInsert");
                }
                else
                {
                    param.Add("@action", "SubMenuUpdate");
                }
                Connection.Execute("USP_SubMenuTable", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<SubMenuEntity>> SubMenuSelectAll(SubMenuEntity submenuclass)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "SubMenuSelectAll");
                var x = Connection.Query<SubMenuEntity>("USP_SubMenuTable", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<SubMenuEntity> SubMenuSelectOne(int SubMenuID)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@SubMenuID", SubMenuID);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                param.Add("@action", "SubMenuSelectOne");
                var x = Connection.Query<SubMenuEntity>("USP_SubMenuTable", param, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
