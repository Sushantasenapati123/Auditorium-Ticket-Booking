using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.ShowsMaster;

namespace OHSB.IRepository.ShowsMaster
{
    public interface IShowRepository
    {
        Task<int> insertupdateShow(ShowEntity entity);
        Task<List<ShowEntity>> GetAllAuditorium();
        Task<int> deleteShow(ShowEntity p);

        Task<List<ShowEntity>> GetAllShowsData();

        Task<ShowEntity> GetShowsbyid(int id);


        //*********************************************
       

    }
}
