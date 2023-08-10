using Auditorium.Domain.ShowSelect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditorium.IRepository.ShowSelectIRepo
{
    public interface ShowSelectIRepository
    {
        Task<int> Create(ShowSelect entity);
        Task<List<ShowSelect>> GetAll();
        Task<int> Delete(int Id);
        Task<ShowSelect> Getbyid(int id);
    }
}
