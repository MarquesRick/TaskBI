using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Localactivity
    {
        [_MapperTO("LAC_ID")]
        public int lac_id { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        [_MapperTO("LOC_ID")]
        public int loc_id { get; set; }

      

    }
}
