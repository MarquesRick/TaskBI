using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Activityfield
    {
        [_MapperTO("ACF_ID")]
        public int acf_id { get; set; }

        [_MapperTO("ACF_INTEGRATIONID")]
        public string acf_integrationid { get; set; }

        [_MapperTO("ACF_DESCRIPTION")]
        public string acf_description { get; set; }

        [_MapperTO("ACF_FIELDTYPE")]
        public string acf_fieldtype { get; set; }

        [_MapperTO("ACF_ACTIVE")]
        public string acf_active { get; set; }

        [_MapperTO("ACS_ID")]
        public int acs_id { get; set; }

        [_MapperTO("ACF_DISPLAYORDER")]
        public int acf_displayorder { get; set; }

        [_MapperTO("ACF_SHOWWEBREPORT")]
        public string acf_showwebreport { get; set; }

        [_MapperTO("ACF_FIELDSIZE")]
        public int acf_fieldsize { get; set; }

        [_MapperTO("ACF_DECIMALPLACES")]
        public int acf_decimalplaces { get; set; }

    }
}
