using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Customfield
    {
        [_MapperTO("CFD_ID")]
        public string cfd_id { get; set; }

        [_MapperTO("CFD_INTEGRATIONID")]
        public string cfd_integrationid { get; set; }

        [_MapperTO("CFD_DESCRIPTION")]
        public string cfd_description { get; set; }

        [_MapperTO("CFD_TYPE")]
        public string cfd_type { get; set; }

        [_MapperTO("CFD_SUBTYPE")]
        public string cfd_subtype { get; set; }

        [_MapperTO("CFD_SIZE")]
        public int cfd_size { get; set; }

        [_MapperTO("CFD_TABLE")]
        public string cfd_table { get; set; }

        [_MapperTO("CFD_ACTIVE")]
        public string cfd_active { get; set; }

        [_MapperTO("CET_ID")]
        public int cet_id { get; set; }

        [_MapperTO("CFD_SOURCEID")]
        public int cfd_sourceid { get; set; }

        [_MapperTO("CFD_SOURCETABLE")]
        public int cfd_sourcetable { get; set; }

    }
}
