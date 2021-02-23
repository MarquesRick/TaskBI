using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Localgroup
    {
        [_MapperTO("LGP_ID")]
        public int lgp_id { get; set; }

        [_MapperTO("LGP_INTEGRATIONID")]
        public string lgp_integrationid { get; set; }

        [_MapperTO("LGP_DESCRIPTION")]
        public string lgp_description { get; set; }

        [_MapperTO("LGP_ACTIVE")]
        public string lgp_active { get; set; }

        

    }
}
