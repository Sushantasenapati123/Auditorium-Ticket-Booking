using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.SubMenuMaster
{
    public class SubMenuEntity
    {
        //SubMenuId,SubMenuName,MenuNameURL,MenuId,SlNo,SubMenuDescription
        public int SubMenuID { get; set; }
        public string SubMenuName { get; set; }
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public string IconName { get; set; }
        public string SubMenuURL { get; set; }
        public int SlNo { get; set; }
        public string SubMenuDescription { get; set; }
        public int UserId { get; set; }
        public int RollID { get; set; }
        public bool IsChecked { get; set; }
    }
}
