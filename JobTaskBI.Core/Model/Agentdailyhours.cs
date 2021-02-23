using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentdailyhours
    {
        [_MapperTO("ADH_ID")]
        public int adh_id { get; set; }

        [_MapperTO("ADM_ID")]
        public int adm_id { get; set; }

        [_MapperTO("ADH_SEQ")]
        public int adh_seq { get; set; }

        [_MapperTO("ADH_INITIALHOURS")]
        public int adh_initialhours { get; set; }

        [_MapperTO("ADH_FINALHOURS")]
        public int adh_finalhours { get; set; }

        [_MapperTO("ADH_DURATION")]
        public string adh_duration { get; set; }

        [_MapperTO("ADH_TYPE")]
        public string adh_type { get; set; }

        [_MapperTO("ADH_DESCRIPTION")]
        public string adh_description { get; set; }

    }
}
