using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Historymedia
    {
        [_MapperTO("HTM_ID")]
        public int htm_id { get; set; }

        [_MapperTO("HTY_ID")]
        public int hty_id { get; set; }

        [_MapperTO("HTM_INSERTDATEHOUR")]
        public int htm_insertdatehour { get; set; }

        [_MapperTO("HTM_TYPE")]
        public string htm_type { get; set; }

        [_MapperTO("HTM_URL")]
        public string htm_url { get; set; }

        

    }
}
