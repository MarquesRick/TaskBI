using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Itemgroup
    {
        [_MapperTO("IGP_ID")]
        public int igp_id { get; set; }

        [_MapperTO("IGP_INTEGRATIONID")]
        public string igp_integrationid { get; set; }

        [_MapperTO("IGP_DESCRIPTION")]
        public string igp_description { get; set; }

        [_MapperTO("IGP_ACTIVE")]
        public string igp_active { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        

    }
}
