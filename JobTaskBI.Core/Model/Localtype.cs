using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Localtype
    {
        [_MapperTO("LTY_ID")]
        public int lty_id { get; set; }

        [_MapperTO("LTY_INTEGRATIONID")]
        public string lty_integrationid { get; set; }

        [_MapperTO("LTY_DESCRIPTION")]
        public string lty_description { get; set; }

        [_MapperTO("LTY_ACTIVE")]
        public string lty_active { get; set; }

        

    }
}
