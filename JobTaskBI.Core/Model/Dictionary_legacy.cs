using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Dictionary_legacy
    {
        [_MapperTO("DIC_ID")]
        public int dic_id { get; set; }

        [_MapperTO("DIC_LANGUAGE")]
        public string dic_language { get; set; }

        [_MapperTO("DIC_KEY")]
        public string dic_key { get; set; }

        [_MapperTO("DIC_VALUE")]
        public string dic_value { get; set; }

       
    }
}
