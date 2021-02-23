using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Itemlocal
    {
        [_MapperTO("ITL_ID")]
        public int itl_id { get; set; }

        [_MapperTO("ITE_ID")]
        public int ite_id { get; set; }

        [_MapperTO("LOC_ID")]
        public int loc_id { get; set; }

        

    }
}
