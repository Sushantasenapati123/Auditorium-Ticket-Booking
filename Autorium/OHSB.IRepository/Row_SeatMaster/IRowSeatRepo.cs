using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.Row_SeatMaster;

namespace OHSB.IRepository.Row_SeatMaster
{
    public interface IRowSeatRepo
    {
        Task<int> Create(RowSeatEntity entity);
        Task<List<RowSeatEntity>> GetAll();
        Task<int> delete(RowSeatEntity p);

       // Task<List<RowSeatEntity>> GetAllData(RowSeatEntity p);
        Task<List<RowSeatEntity>> BindRows();
        Task<List<RowSeatEntity>> BindAuditorium();

        Task<RowSeatEntity> Getbyid(int id);
    }
}
