using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.AuditoriumMaster;

namespace OHSB.IRepository.AuditoriumIRepository
{
    public interface IAuditoriumRepo
    {
        Task<int> CreateAuditorium(AuditoriumEntity entity);
        Task<List<AuditoriumEntity>> GetAll();
        Task<int> delete(AuditoriumEntity p);

        //Task<List<AuditoriumEntity>> GetAllData(AuditoriumEntity p);

        Task<AuditoriumEntity> Getbyid(int id);
    }
}
