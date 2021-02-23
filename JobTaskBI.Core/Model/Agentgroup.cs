using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentgroup
    {
        [_MapperTO("AGG_ID")]
        public int agg_id { get; set; }

        [_MapperTO("AGG_INTEGRATIONID")]
        public string agg_integrationid { get; set; }

        [_MapperTO("AGG_DESCRIPTION")]
        public string agg_description { get; set; }

        [_MapperTO("AGG_ACTIVE")]
        public string agg_active { get; set; }

       
    }
}
