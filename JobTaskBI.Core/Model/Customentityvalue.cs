using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Customentityvalue
    {
        [_MapperTO("CEV_ID")]
        public int cev_id { get; set; }

        [_MapperTO("CET_ID")]
        public int cet_id { get; set; }

        [_MapperTO("CEV_INTEGRATIONID")]
        public string cev_integrationid { get; set; }

        [_MapperTO("CEV_DESCRIPTION")]
        public string cev_description { get; set; }

        [_MapperTO("CEV_ACTIVE")]
        public string cev_active { get; set; }

       

    }
}
