using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Activitytype
    {
        [_MapperTO("ATY_ID")]
        public int aty_id { get; set; }

        [_MapperTO("ATY_INTEGRATIONID")]
        public string aty_integrationid { get; set; }

        [_MapperTO("ATY_DESCRIPTION")]
        public string aty_description { get; set; }

        [_MapperTO("ATY_ACTIVE")]
        public string aty_active { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        
    }
}
