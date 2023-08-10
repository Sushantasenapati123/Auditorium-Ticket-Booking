using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.ScreenMap;

namespace OHSB.IRepository.ScreenMap
{
    public interface IScreenMap
    {
        Task<List<ScreenMapEntity>> findallFilm();

        Task<List<ScreenMapEntity>> GetAuditoriumAndTimebyShowid(int showid);
        Task<int> insertupdate(ScreenMapEntity entity);
        Task<List<ScreenMapEntity>> GetAllShowType();
        Task<List<ScreenMapEntity>> GetAllShow();
        Task<List<ScreenMapEntity>> GetAllData();
        Task<ScreenMapEntity> GetShowsbyid(int id); 
             Task<ScreenMapEntity> GetbyShowid(int id);
        Task<int> deleteShow(ScreenMapEntity p);
        Task<ScreenMapEntity> GetShowsTimebyid( int ShowId);//for show time
    }
}
