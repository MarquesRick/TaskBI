using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Customfieldvalue
    {
        [_MapperTO("CFV_ID")]
        public int cfv_id { get; set; }

        [_MapperTO("CFD_ID")]
        public string cfd_id { get; set; }

        [_MapperTO("CFV_INTERNALVALUE")]
        public string cfv_internalvalue { get; set; }

        [_MapperTO("CFV_EXTERNALVALUE")]
        public string cfv_externalvalue { get; set; }

        [_MapperTO("CFV_REGISTERID")]
        public string cfv_registerid { get; set; }

       

    }
}
