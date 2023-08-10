using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.PermissionMaster
{
    public class PermissionEntity
    {
        // PermissionId,SubMenuID,RollID,SubMenuDescription
        public int PermissionId { get; set; }
        public int SubMenuID { get; set; }
        public string MenuName { get; set; }
        public string SubMenuName { get; set; }
        public int RollID { get; set; }
        public string RollName { get; set; }
        public int UserId { get; set; }
        public string SubMenuDescription { get; set; }
        public bool IsChecked { get; set; }
    }
}
