using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OHSB.Domain.PermissionMaster;
using OHSB.Domain.SubMenuMaster;
using OHSB.Domain.MenuMaster;

namespace OHSB.IRepository.PermissionMaster
{
    public interface IPermissionRepo
    {
        Task<int> PermissionInsert(PermissionEntity entity);
        Task<int> PermissionUpdateToDelete(int RollID, int UserId);
        Task<List<PermissionEntity>> RollDDL();
        Task<List<SubMenuEntity>> GetSelectedSubMenus(int RollID, int UserId);
        Task<List<SubMenuEntity>> GetSelectedMenuByDesig(int RollID, int UserId);
        Task<List<SubMenuEntity>> GetSelectedSubMenuByDesig(int RollID, int UserId);
    }
}
