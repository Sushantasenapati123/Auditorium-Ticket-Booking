using Auditorium.Domain.SeatMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.IRepository.Seat
{
    public interface SeatIRepository
    {
        Task<int> CreateSeat(SeatMaster entity);
        Task<List<SeatMaster>> GetAll();
        Task<int> delete(SeatMaster p);
        Task<SeatMaster> Getbyid(int id);
        Task<List<SeatMaster>> SelectAllForBlock(int AuditoriumId);
    }
}

 