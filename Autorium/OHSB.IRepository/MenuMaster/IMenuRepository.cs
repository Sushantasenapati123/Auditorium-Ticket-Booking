using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.MenuMaster;

namespace OHSB.IRepository.MenuMaster
{
   public interface IMenuRepository
    {
        Task<List<MenuEntity>> MenuSelectAll(MenuEntity menuclass);
        Task<MenuEntity> MenuSelectOne(int MenuId);
        Task<int> MenuInsertAndUpdate(MenuEntity entity);
        Task<int> MenuDelete(int MenuId);
    }
}
