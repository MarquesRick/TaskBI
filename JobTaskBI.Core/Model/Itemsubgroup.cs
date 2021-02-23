using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Itemsubgroup
    {
        [_MapperTO("ISG_ID")]
        public int isg_id { get; set; }

        [_MapperTO("ISG_INTEGRATIONID")]
        public string isg_integrationid { get; set; }

        [_MapperTO("ISG_DESCRIPTION")]
        public string isg_description { get; set; }

        [_MapperTO("ISG_ACTIVE")]
        public string isg_active { get; set; }

        [_MapperTO("IGP_ID")]
        public int igp_id { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

       

    }
}
