
using System.Collections.Generic;

using System.Threading.Tasks;

using OHSB.Domain.AuditoriumMaster;

namespace Auditorium.IRepository.Auditorium
{
    public interface AuditoriumIRepository
    {
        Task<int> CreateAuditorium(AuditoriumMaster entity);
        Task<List<AuditoriumMaster>> GetAll();
        Task<int> delete(AuditoriumMaster p);
        Task<List<AuditoriumMaster>> AuditoriumBind();
        Task<AuditoriumMaster> Getbyid(int id);
        /*-------------------------------------------------*/
        Task<List<AudiBlockRowMap>> ShowBlockAndRowName();
        Task<int> InsertBlockAndRow(int Id, int AuditoriumId, int BlockId, int[] RowId);
        Task<AudiBlockRowMap> GetOnebyid(int Id);
        Task<int> Delete(int Id);

    }
}
