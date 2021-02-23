using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Media
    {
        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("MED_DESCRIPTION")]
        public string med_description { get; set; }

        [_MapperTO("MED_PUBLICURL")]
        public string med_publicurl { get; set; }

        [_MapperTO("MED_STATUS")]
        public string med_status { get; set; }

        

    }
}
