using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Team
    {
        [_MapperTO("TEA_ID")]
        public int tea_id { get; set; }

        [_MapperTO("TEA_INTEGRATIONID")]
        public string tea_integrationid { get; set; }

        [_MapperTO("TEA_DESCRIPTION")]
        public string tea_description { get; set; }

        [_MapperTO("TEA_ACTIVE")]
        public string tea_active { get; set; }

        [_MapperTO("TEA_TEAMSUPERVISOR")]
        public int tea_teamsupervisor { get; set; }

        [_MapperTO("TET_ID")]
        public int tet_id { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        

    }
}
