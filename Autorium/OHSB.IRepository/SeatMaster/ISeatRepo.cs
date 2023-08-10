using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.SeatMaster;

namespace OHSB.IRepository.SeatMaster
{
    public interface ISeatRepo
    {
        Task<int> InsertSeat(SeatEntity entity);
        Task<int> deleteSeat(SeatEntity p);
        Task<List<SeatEntity>> GetAllSeat();
        Task<SeatEntity> GetSeatbyid(int id);
        Task<SeatEntity> GetseatCapacitybyid( int SeatId);
        //Task<int> insertSeatnos(int x,int y);

        Task<List<SeatEntity>> GetSeatdetailsbyid(int id);
   
            Task<int> insertSeatnos(SeatNumbers nos);
        Task<int> deleteSeatNos(int p);
        Task<List<SeatEntity>> checkrowandauditorium(SeatEntity rows);
        //demo
        Task<List<SeatNumbers>> GetSeatNosbyid(int id);
    }
}
