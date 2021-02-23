using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Localclass
    {
        [_MapperTO("LCL_ID")]
        public int lcl_id { get; set; }

        [_MapperTO("LCL_INTEGRATIONID")]
        public string lcl_integrationid { get; set; }

        [_MapperTO("LCL_DESCRIPTION")]
        public string lcl_description { get; set; }

        [_MapperTO("LCL_ACTIVE")]
        public string lcl_active { get; set; }

       

        

    }
}
