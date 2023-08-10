using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSB.Domain.BlockRowMapping
{
    public class BlockRowEntity
    {
        public int BlockRowID { get; set; }
        public int AuditoriumID { get; set; }
        public int BlockId { get; set; }
        public int Row_No { get; set; }
        public bool IsChecked { get; set; }

        public string AuditoriumName { get; set; }
        public string BlockName { get; set; }
        public string RowDesc { get; set; }

        public List<Rownumbers> RowNumber { get; set; }
        public string[] selectedRows { get; set; } 
        public class Rownumbers
        {
            public int BlockRowID { get; set; }
            public int AuditoriumID { get; set; }
            public int BlockId { get; set; }
            public int Row_No { get; set; }
            public string RowDesc { get; set; }
            public bool IsChecked { get; set; }

        }

    }
   
}
