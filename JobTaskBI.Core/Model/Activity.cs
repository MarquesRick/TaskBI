using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Activity
    {
        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        [_MapperTO("ACT_INTEGRATIONID")]
        public string act_integrationid { get; set; }

        [_MapperTO("ACT_DESCRIPTION")]
        public string act_description { get; set; }

        [_MapperTO("ACT_ACTIVE")]
        public string act_active { get; set; }

        [_MapperTO("ATY_ID")]
        public int aty_id { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("ACT_DISPLAYORDER")]
        public string act_displayorder { get; set; }

        
    }
}
