using Dapper;
using OHSB.Domain.EmployeeMaster;
using OHSB.IRepository.Employee_Master;
using OHSB.IRepository.Factory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Repository.EmployeeMaster
{
    public class EmployeeRepository : RepositoryBase, IEmployeeRepository
    {
        public EmployeeRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<List<EmployeeEntity>> BindDepartment()
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@mode", "BindDepartMent");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var x = Connection.Query<EmployeeEntity>("USP_USER", param, commandType: CommandType.StoredProcedure).ToList();
                return x;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<EmployeeEntity>> BindDesignation()
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@mode", "BindDesignation");
                var query = "USP_USER";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var GetAppById = Connection.Query<EmployeeEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();

                return GetAppById;

            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task<List<EmployeeEntity>> BindRole()
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@mode", "Bind");
                var query = "USP_USER";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var GetAppById = Connection.Query<EmployeeEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById;

            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task<int> delete(int p)
        {
            try
            {


                DynamicParameters param = new DynamicParameters();

                param.Add("@UserId", p);

                param.Add("@mode", "D");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                Connection.Execute("[USP_USER]", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));

                return x;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

       

        public async Task<List<EmployeeEntity>> GetAllUser(EmployeeEntity us)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@mode", "A");
                ObjParm.Add("@FullName", us.FullName);
                ObjParm.Add("@DesignationId ", us.DesignationId);
                var query = "USP_USER";
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);

                var GetAppById = Connection.Query<EmployeeEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();

                return GetAppById;

            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task<EmployeeEntity> GetbyidUser(int id)
        {
            try
            {
                DynamicParameters ObjParm = new DynamicParameters();
                ObjParm.Add("@UserId", id);
                ObjParm.Add("@mode", "S");
                ObjParm.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                var query = "USP_USER";
                var GetAppById = Connection.Query<EmployeeEntity>(query, ObjParm, commandType: CommandType.StoredProcedure).AsList();
                return GetAppById[0];
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public async Task<int> insert(EmployeeEntity om)
        {
            try
            {   DynamicParameters param = new DynamicParameters();
                param.Add("@UserId", om.UserId);
                param.Add("@UserName", om.UserName);
                param.Add("@Password", om.Password);
                param.Add("@FullName", om.FullName);
                param.Add("@Email", om.Email);
                param.Add("@Mobile", om.Mobile);
                param.Add("@Gender", om.Gender);
                param.Add("@Address", om.Address);
                param.Add("@Age", om.Age);
                param.Add("@City", om.City);
                param.Add("@DesignationId", om.DesignationId);
                param.Add("@DepartmentId", om.DepartmentId);
                param.Add("@AuditoriumID", om.AuditoriumID);
                param.Add("@RollID", om.RollID);
                param.Add("@mode", "IU");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                Connection.Execute("USP_USER", param, commandType: CommandType.StoredProcedure);
                int x = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return x;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        //////////////////////////////////////////////////////////
        /////////////////////////LogIn////////////////////////////////
        public async Task<EmployeeEntity> UserGetByUserNamePwd(string UserName, string Password)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@action", "LoginPage");
                param.Add("@UserName", UserName);
                param.Add("@Password", Password);
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                string spName = "[USP_USER_LOGIN_MANAGE]";
                var user = await Connection.QueryAsync<EmployeeEntity>(spName, param, commandType: CommandType.StoredProcedure);
                return user.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<int> UpdatePassword(EmployeeEntity ue)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();

                param.Add("@UserName", ue.UserName);
                param.Add("@Password", ue.Password);
                param.Add("@action", "changepassword");
                param.Add("@PMSGOUT", dbType: DbType.String, direction: ParameterDirection.Output, size: 5215585);
                string spName = "[USP_USER_LOGIN_MANAGE]";
                Connection.Execute(spName, param, commandType: CommandType.StoredProcedure);
                int result = Convert.ToInt32(param.Get<string>("@PMSGOUT"));
                return result;


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
