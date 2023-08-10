using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.OHSB_Master;


namespace OHSB.IRepository.OHSB_IRepository
{
    public interface IOHSB_Master
    {
       Task<int> CreateDepartMent(OHSB_Entity entity);
        Task<List<OHSB_Entity>> GetAllDepartment();
        Task<int> deleteDepartment(OHSB_Entity p);
        Task<OHSB_Entity> GetDepartmentbydepartmentId(int id);

        //Designation////////////////
        Task<int> CreateDesignation(OHSB_Entity entity);
        Task<List<OHSB_Entity>> GetAllDesignation();
        Task<int> deleteDesignation(OHSB_Entity p);
        Task<OHSB_Entity> GetDesignationbyDesignationId(int id);


        //////Roll//////
        Task<int> CreateRoll(OHSB_Entity entity);
        Task<List<OHSB_Entity>> GetAllRoll();
        Task<int> deleteRoll(OHSB_Entity p);
        Task<OHSB_Entity> GetRollbyRollId(int id);


    }
}
