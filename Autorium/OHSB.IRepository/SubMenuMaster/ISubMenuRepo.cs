using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.SubMenuMaster;
using OHSB.Domain.MenuMaster;

namespace OHSB.IRepository.SubMenuMaster
{
    public interface ISubMenuRepo
    {
        Task<List<SubMenuEntity>> SubMenuSelectAll(SubMenuEntity submenuclass);
        Task<SubMenuEntity> SubMenuSelectOne(int SubMenuId);
        Task<int> SubMenuInsertAndUpdate(SubMenuEntity entity);
        Task<int> SubMenuDelete(int SubMenuId);
        Task<List<MenuEntity>> GetAllMenu();
    }
}
