using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Teamtype
    {
        [_MapperTO("TET_ID")]
        public int tet_id { get; set; }

        [_MapperTO("TET_INTEGRATIONID")]
        public string tet_integrationid { get; set; }

        [_MapperTO("TET_DESCRIPTION")]
        public string tet_description { get; set; }

        [_MapperTO("TET_ACTIVE")]
        public string tet_active { get; set; }

        

    }
}
