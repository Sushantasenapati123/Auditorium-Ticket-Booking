using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.EmployeeMaster;

namespace OHSB.IRepository.Employee_Master
{
    public interface IEmployeeRepository
    {
        Task<int> insert(EmployeeEntity p);
        Task<int> delete(int p);
        Task<List<EmployeeEntity>> GetAllUser(EmployeeEntity us);
        Task<EmployeeEntity> GetbyidUser(int id);
        Task<List<EmployeeEntity>> BindRole();
        Task<List<EmployeeEntity>> BindDepartment();
        Task<List<EmployeeEntity>> BindDesignation();

        //LogIn
        Task<EmployeeEntity> UserGetByUserNamePwd(string UserName, string Password);
        Task<int> UpdatePassword(EmployeeEntity ue);
    }
}
