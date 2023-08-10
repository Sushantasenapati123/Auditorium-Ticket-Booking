using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.EmployeeMaster
{
    public class EmployeeEntity
    {
        public int UserId { get; set; } = 0;
        public string UserName { get; set; } = null;
        public string Password { get; set; } = null;
        public string Passwordconfirm { get; set; } = null;
        public string FullName { get; set; } = null;
        public string Email { get; set; } = null;
        public string Mobile { get; set; } = null;
        public string Gender { get; set; } = null;
        public string Address { get; set; } = null;
        public string City { get; set; } = null;
        public int Age { get; set; } = 0;
        public string DOB { get; set; } = null;
        public int DesignationId { get; set; } = 0;//[Designation]
        [NotMapped]
        public string Designation { get; set; } = null;

        public int DepartmentId { get; set; } 
        public string Department { get; set; }
        public int RollID { get; set; } = 0;
        public string RollName { get; set; } = null;
        public int AuditoriumID { get; set; } = 0;
        public string AuditoriumName { get; set; } = null;
        public int DeletedFlag { get; set; } = 0;
    }
}

