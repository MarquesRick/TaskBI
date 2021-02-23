using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Historyvalue
    {
        [_MapperTO("HTV_ID")]
        public int htv_id { get; set; }

        [_MapperTO("HTY_ID")]
        public int hty_id { get; set; }

        [_MapperTO("ITE_ID")]
        public int ite_id { get; set; }

        [_MapperTO("ACS_ID")]
        public int acs_id { get; set; }

        [_MapperTO("ACF_ID")]
        public int acf_id { get; set; }

        [_MapperTO("HTV_INTERNALVALUE")]
        public string htv_internalvalue { get; set; }

        [_MapperTO("HTV_EXTERNALVALUE")]
        public string htv_externalvalue { get; set; }

        [_MapperTO("HTV_EXECUTIONGROUP")]
        public int htv_executiongroup { get; set; }

    }
}
