using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Taskactivity
    {
        [_MapperTO("TSA_ID")]
        public int tsa_id { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        [_MapperTO("TSK_ID")]
        public int tsk_id { get; set; }

        [_MapperTO("TSA_MANDATORY")]
        public string tsa_mandatory { get; set; }

        [_MapperTO("TSA_MOBILEINACTIVE")]
        public string tsa_mobileinactive { get; set; }

        [_MapperTO("TSA_ACTIVE")]
        public string tsa_active { get; set; }

       

    }
}
