using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.RowMaster;
namespace OHSB.IRepository.RowMaster
{
    public interface IRowRepository
    {
        //Row
        Task<int> InsertRow(RowEntity entity);
        //Task<List<RowEntity>> GetAll();
        Task<int> deleteRow(RowEntity p);

        Task<List<RowEntity>> GetAllRows(RowEntity p);

        Task<RowEntity> GetRowbyid(int id);

        //Seatno
        Task<int> InsertSeat(RowEntity entity);
        Task<int> deleteSeat(RowEntity p);

        Task<List<RowEntity>> GetAllSeats(RowEntity p);

        Task<RowEntity> GetSeatbyid(int id);
        Task<List<RowEntity>> GetAll();
    }
}
