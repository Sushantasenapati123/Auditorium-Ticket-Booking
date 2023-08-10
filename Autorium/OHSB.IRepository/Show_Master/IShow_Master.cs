using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.Show_Master;

namespace OHSB.IRepository.Show_Master
{
   public interface IShow_Master
    {
        Task<List<Show_Entity>> GetAllShowType();
        Task<int> insertupdateShow(Show_Entity entity);
        Task<List<Show_Entity>> GetAllShowsData();
        Task<Show_Entity> GetShowsbyid(int id);
        Task<int> deleteShow(Show_Entity p);
    }
}
