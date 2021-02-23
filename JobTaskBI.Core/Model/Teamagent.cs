using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Teamagent
    {
        [_MapperTO("TAG_ID")]
        public int tag_id { get; set; }

        [_MapperTO("TEA_ID")]
        public int tea_id { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("TAG_RESPONSIBLE")]
        public string tag_responsible { get; set; }

        [_MapperTO("TAG_ACTIVE")]
        public string tag_active { get; set; }

       

    }
}
