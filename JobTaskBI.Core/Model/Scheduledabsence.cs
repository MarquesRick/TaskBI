using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Scheduledabsence
    {
        [_MapperTO("SCA_ID")]
        public int sca_id { get; set; }

        [_MapperTO("SCA_DESCRIPTION")]
        public string sca_description { get; set; }

        [_MapperTO("SCA_ACTION")]
        public string sca_action { get; set; }

        [_MapperTO("SCA_INITIALDATEHOUR")]
        public int sca_initialdatehour { get; set; }

        [_MapperTO("SCA_FINALDATEHOUR")]
        public int sca_finaldatehour { get; set; }

        [_MapperTO("AGE_ID_ORIGIN")]
        public int age_id_origin { get; set; }

        [_MapperTO("AGE_ID_DESTINY")]
        public int age_id_destiny { get; set; }

        [_MapperTO("SCA_ACTIVE")]
        public string sca_active { get; set; }

    }
}
