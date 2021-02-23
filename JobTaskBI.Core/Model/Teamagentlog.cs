using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Teamagentlog
    {
        [_MapperTO("TAL_ID")]
        public int tal_id { get; set; }

        [_MapperTO("TAL_DATEHOUR")]
        public int tal_datehour { get; set; }

        [_MapperTO("TAL_OPERATION")]
        public string tal_operation { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("TAL_MODULE")]
        public string tal_module { get; set; }

        [_MapperTO("TAL_DATA")]
        public string tal_data { get; set; }

        
    }
}
