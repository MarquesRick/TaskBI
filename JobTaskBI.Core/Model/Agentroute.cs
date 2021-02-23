using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentroute
    {
        [_MapperTO("AGR_ID")]
        public int agr_id { get; set; }

        [_MapperTO("ROT_ID")]
        public int rot_id { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        
    }
}
