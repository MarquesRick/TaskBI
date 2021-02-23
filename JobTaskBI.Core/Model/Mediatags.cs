using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Mediatags
    {
        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("MED_TAGS")]
        public string med_tegs { get; set; }

        [_MapperTO("HTV_ID")]
        public int htv_id { get; set; }

        

    }
}
