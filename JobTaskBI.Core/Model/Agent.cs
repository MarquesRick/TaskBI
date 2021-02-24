using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agent
    {
        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("AGE_INTEGRANTIONID")]
        public string age_integrationid { get; set; }

        [_MapperTO("AGE_NAME")]
        public string age_name { get; set; }

        [_MapperTO("AGE_LOGIN")]
        public string age_login { get; set; }

        [_MapperTO("AGE_OBSERVATION")]
        public string age_observation { get; set; }

        [_MapperTO("AGE_COUNTRY")]
        public string age_country { get; set; }

        [_MapperTO("AGE_STATE")]
        public string age_state { get; set; }

        [_MapperTO("AGE_CITY")]
        public string age_city { get; set; }

        [_MapperTO("AGE_NEIGHBORHOOD")]
        public string age_neighborhood { get; set; }

        [_MapperTO("AGE_STREET")]
        public string age_street { get; set; }

        [_MapperTO("AGE_STREETNUMBER")]
        public int age_streetnumber { get; set; }

        [_MapperTO("AGE_STREETNUMBERCOMPL")]
        public string age_streetnumbercompl { get; set; }

        [_MapperTO("AGE_ZIPCODE")]
        public int age_zipcode { get; set; }

        [_MapperTO("AGE_PHONE")]
        public string age_phone { get; set; }

        [_MapperTO("AGE_MOBILEPHONE")]
        public string age_mobilephone { get; set; }

        [_MapperTO("AGE_MAIL")]
        public string age_mail { get; set; }

        [_MapperTO("AGE_IMEILASTSYNC")]
        public string age_imeilastsync { get; set; }

        [_MapperTO("AGE_DATEHOURLASTSYNC")]
        public DateTime age_datehourlastsync { get; set; }

        [_MapperTO("AGG_ID")]
        public int agg_id { get; set; }

        [_MapperTO("AGE_ACTIVE")]
        public string age_active { get; set; }

        [_MapperTO("AGE_MOBILEVERSION")]
        public string age_mobileversion { get; set; }

        [_MapperTO("AGE_LASTGEOPOSITION")]
        public string age_lastgeoposition { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("AGE_GEOPOSITION")]
        public string age_geoposition { get; set; }

        [_MapperTO("AGE_BATTERYLEVEL")]
        public int age_batterylevel { get; set; }

        [_MapperTO("AGE_MOBILEPLATFORMTYPE")]
        public string age_mobileplatformtype { get; set; }

        [_MapperTO("AGE_MOBILEPLATFORMVERSION")]
        public string age_mobileplatformversion { get; set; }

        [_MapperTO("AGE_IGNORETEAMFILTER")]
        public string age_ignoreteamfilter { get; set; }

        [_MapperTO("AGE_ID_INSERT")]
        public int age_id_insert { get; set; }

        [_MapperTO("AGE_DATETIMEINSERT")]
        public DateTime age_datetimeinsert { get; set; }

        [_MapperTO("AGE_MODULEINSERT")]
        public string age_moduleinsert { get; set; }

        [_MapperTO("AGE_ID_LASTUPDATE")]
        public int age_id_lastupdate { get; set; }

        [_MapperTO("AGE_DATETIMELASTUPDATE")]
        public DateTime age_datetimelastupdate { get; set; }

        [_MapperTO("AGE_MODULELASTUPDATE")]
        public string age_modulelastupdate { get; set; }

        [_MapperTO("AGE_DATETIMELASTGPS")]
        public DateTime age_datetimelastgps { get; set; }

        [_MapperTO("AGE_CUSTOMERPORTFOLIOFILTER")]
        public string age_customerportfoliofilter { get; set; }

        [_MapperTO("WKJ_ID")]
        public int wkj_id { get; set; }

      
    }
}
