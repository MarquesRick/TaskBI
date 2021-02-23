using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Itemcategory
    {
        [_MapperTO("ICY_ID")]
        public int icy_id { get; set; }

        [_MapperTO("ICY_INTEGRATIONID")]
        public string icy_integrationid { get; set; }

        [_MapperTO("ICY_DESCRIPTION")]
        public string icy_description { get; set; }

        [_MapperTO("ICY_ACTIVE")]
        public string icy_active { get; set; }

        

    }
}
