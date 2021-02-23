using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Taskitem
    {
        [_MapperTO("TSI_ID")]
        public int tsi_id { get; set; }

        [_MapperTO("TSK_ID")]
        public int tsk_id { get; set; }

        [_MapperTO("ITE_ID")]
        public int ite_id { get; set; }

        

    }
}
