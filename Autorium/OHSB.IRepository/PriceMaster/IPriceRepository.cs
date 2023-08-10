using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.PriceMaster;

namespace OHSB.IRepository.PriceMaster
{
   public interface IPriceRepository
    {
        Task<List<PriceEntity>> GetAllAuditorium();
        Task<List<PriceEntity> >GetAllblock(int AuditoriumID);
        Task<List<PriceEntity>> GetAllRow(int BlockId);
        Task<int> insertupdate(PriceEntity entity);
        Task<List<PriceEntity>> GetAllPrice();
        Task<int> delete(PriceEntity p);
        Task<PriceEntity> Getbyid(int id);
    }
}
