using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Dictionary_new_customer
    {
        [_MapperTO("DIC_ID")]
        public int dic_id { get; set; }

        [_MapperTO("DIC_LANGUAGE")]
        public string dic_language { get; set; }

        [_MapperTO("DIC_KEYS")]
        public string dic_keys { get; set; }

       

    }
}
