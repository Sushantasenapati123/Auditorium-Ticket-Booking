using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.OHSB_Master
{
    public class OHSB_Entity
    {
       
        public int DepartmentId { get; set; }
        public string Department { get; set; }
       
        //Designation
        public int DesignationId { get; set; }
        public string Designation { get; set; }

        //Roll
        public int RollID { get; set; }
        public string RollName { get; set; }
        public bool DeletedFlag { get; set; }
    }
}
