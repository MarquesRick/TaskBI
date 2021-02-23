using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentactivity
    {
        [_MapperTO("AAC_ID")]
        public int aac_id { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        
    }
}
