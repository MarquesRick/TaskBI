using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Activitysection
    {
        [_MapperTO("ACS_ID")]
        public int acs_id { get; set; }

        [_MapperTO("ACS_INTEGRATIONID")]
        public string acs_integrationid { get; set; }

        [_MapperTO("ACS_DESCRIOPTION")]
        public string acs_description { get; set; }

        [_MapperTO("ACS_ACTIVE")]
        public string acs_active { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("ACS_DISPLAYORDER")]
        public int acs_displayorder { get; set; }


    }
}
