using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Localroute
    {
        [_MapperTO("LOR_ID")]
        public int lor_id { get; set; }

        [_MapperTO("LOR_EXECUTIONORDER")]
        public int lor_executionorder { get; set; }

        [_MapperTO("ROT_ID")]
        public int rot_id { get; set; }

        [_MapperTO("LOC_ID")]
        public int loc_id { get; set; }

        
    }
}
