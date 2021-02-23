using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Local
    {
        [_MapperTO("LOC_ID")]
        public int loc_id { get; set; }

        [_MapperTO("LOC_INTEGRATIONID")]
        public string loc_integrationid { get; set; }

        [_MapperTO("LOC_DESCRIPTION")]
        public string loc_description { get; set; }

        [_MapperTO("LOC_CORPORATENAME")]
        public string loc_corporatename { get; set; }

        [_MapperTO("LOC_OBSERVATION")]
        public string loc_observation { get; set; }

        [_MapperTO("LOC_COUNTRY")]
        public string loc_country { get; set; }

        [_MapperTO("LOC_STATE")]
        public string loc_state { get; set; }

        [_MapperTO("LOC_CITY")]
        public string loc_city { get; set; }

        [_MapperTO("LOC_NEIGHBORHOOD")]
        public string loc_neighborhood { get; set; }

        [_MapperTO("LOC_STREET")]
        public string loc_street { get; set; }

        [_MapperTO("LOC_STREETNUMBER")]
        public int loc_streetnumber { get; set; }

        [_MapperTO("LOC_STREETNUMBERCOMPL")]
        public string loc_streetnumbercompl { get; set; }

        [_MapperTO("LOC_ZIPCODE")]
        public string loc_zipcode { get; set; }

        [_MapperTO("LOC_PHONE")]
        public string loc_phone { get; set; }

        [_MapperTO("LOC_MOBILEPHONE")]
        public string loc_mobilephone { get; set; }

        [_MapperTO("LOC_MAIL")]
        public string loc_mail { get; set; }

        [_MapperTO("LOC_GEOPOSITION")]
        public string loc_geoposition { get; set; }

        [_MapperTO("LOC_ACTIVE")]
        public string loc_active { get; set; }

        [_MapperTO("LTY_ID")]
        public int lty_id { get; set; }

        [_MapperTO("LGP_ID")]
        public int lgp_id { get; set; }

        [_MapperTO("LCL_ID")]
        public int lcl_id { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("AGE_ID_INSERT")]
        public int age_id_insert { get; set; }

        [_MapperTO("LOC_DATETIMEINSERT")]
        public int loc_datetimeinsert { get; set; }

        [_MapperTO("LOC_MODULEINSERT")]
        public string loc_moduleinsert { get; set; }

        [_MapperTO("AGE_ID_LASTUPDATE")]
        public int age_id_lastupdate { get; set; }

        [_MapperTO("LOC_DATETIMELASTUPDATE")]
        public int loc_datetimelastupdate { get; set; }

        [_MapperTO("LOC_MODULELASTUPDATE")]
        public string loc_modulelastupdate { get; set; }

        [_MapperTO("TEA_ID")]
        public int tea_id { get; set; }

        [_MapperTO("LOC_GEOPOSITIONPRECISION")]
        public string loc_geopositionprecision { get; set; }

    }
}
