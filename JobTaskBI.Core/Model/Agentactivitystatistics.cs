using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentactivitystatistics
    {
        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        [_MapperTO("AAS_DATE")]
        public int aas_date { get; set; }

        [_MapperTO("AAS_CREATEDAT")]
        public int aas_createdat { get; set; }

        [_MapperTO("AAS_LASTUPDATE")]
        public int aas_lastupdate { get; set; }

        [_MapperTO("AAS_EXECUTEDTASKS")]
        public int aas_executedtasks { get; set; }

        [_MapperTO("AAS_COLLECTEDIMAGES")]
        public int aas_collectedimages { get; set; }

        [_MapperTO("AAS_EXECUTIONTIME")]
        public int aas_executiontime { get; set; }

        [_MapperTO("AAS_EXECUTEDLATE")]
        public int aas_executedlate { get; set; }

        [_MapperTO("AAS_EXECUTEDONTIME")]
        public int aas_executedontime { get; set; }

        [_MapperTO("AAS_EXECUTEDEARLY")]
        public int aas_executedearly { get; set; }

  
    }
}
