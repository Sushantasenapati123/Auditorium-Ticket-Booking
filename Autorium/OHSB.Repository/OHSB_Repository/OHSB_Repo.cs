using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using OHSB.Domain.OHSB_Master;
using OHSB.IRepository.Factory;
using OHSB.IRepository.OHSB_IRepository;
namespace OHSB.Repository.OHSB_Repository
{
    public class OHSB_Repo : RepositoryBase, IOHSB_Master
    {
        public OHSB_Repo(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<int> CreateDepartMent(OHSB_Entity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DepartmentId", entity.DepartmentId);
                param.Add("@Department", entity.Department);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.DepartmentId == 0)
                {
                    param.Add("@action", "Insert");
                }
                else
                {
                    param.Add("@action", "Update");
                }

                var query = "[USP_Department]";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<OHSB_Entity>> GetAllDepartment()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<OHSB_Entity>("USP_Department", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<OHSB_Entity> GetDepartmentbydepartmentId(int DepartmentId)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@DepartmentId", DepartmentId);
                ObjParm.Add("@action", "SelectOne");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_Department";
                var GetAppById = Connection.Query<OHSB_Entity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        public async Task<int> deleteDepartment(OHSB_Entity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@DepartmentId", p.DepartmentId);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "Delete");
                Connection.Execute("[USP_Department]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        /////designation Repository/////
        public async Task<int> CreateDesignation(OHSB_Entity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@DesignationId", entity.DesignationId);
                param.Add("@Designation", entity.Designation);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.DesignationId == 0)
                {
                    param.Add("@action", "InsertDesignation");
                }
                else
                {
                    param.Add("@action", "UpdateDesignation");
                }

                var query = "USP_Designation";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<OHSB_Entity>> GetAllDesignation()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAllDesignation");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<OHSB_Entity>("USP_Designation", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<OHSB_Entity> GetDesignationbyDesignationId(int DesignationId)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@DesignationId", DesignationId);
                ObjParm.Add("@action", "SelectOneDesignation");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_Designation";
                var GetAppById = Connection.Query<OHSB_Entity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        public async Task<int> deleteDesignation(OHSB_Entity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@DesignationId", p.DesignationId);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "DeleteDesignation");
                Connection.Execute("[USP_Designation]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;

            }
            catch (Exception ex)
            {

                return 0;
            }
        }

        /////////Roll/////
        public async Task<int> CreateRoll(OHSB_Entity entity)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@RollID", entity.RollID);
                param.Add("@RollName", entity.RollName);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                if (entity.RollID == 0)
                {
                    param.Add("@action", "InsertRoll");
                }
                else
                {
                    param.Add("@action", "UpdateRoll");
                }

                var query = "[USP_RollMaster]";

                Connection.Execute(query, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<OHSB_Entity>> GetAllRoll()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "SelectAllRoll");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<OHSB_Entity>("USP_RollMaster", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public async Task<OHSB_Entity> GetRollbyRollId(int RollID)
        {
            try
            {

                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@RollID", RollID);
                ObjParm.Add("@action", "SelectOneRoll");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_RollMaster";
                var GetAppById = Connection.Query<OHSB_Entity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }

        }
        public async Task<int> deleteRoll(OHSB_Entity p)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@RollID", p.RollID);

                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);


                param.Add("@action", "DeleteRoll");
                Connection.Execute("[USP_RollMaster]", param, commandType: CommandType.StoredProcedure);
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


