using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Workjourney
    {
        [_MapperTO("WKJ_ID")]
        public int wkj_id { get; set; }

        [_MapperTO("WKJ_INTEGRATIONID")]
        public string wkj_integrationid { get; set; }

        [_MapperTO("WKJ_DESCRIPTION")]
        public string wkj_description { get; set; }

        [_MapperTO("WKJ_ACTIVE")]
        public string wkj_active { get; set; }

       

    }
}
