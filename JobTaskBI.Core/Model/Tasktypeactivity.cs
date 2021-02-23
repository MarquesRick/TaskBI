using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Tasktypeactivity
    {
        [_MapperTO("TTA_ID")]
        public int tta_id { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        [_MapperTO("TTY_ID")]
        public int tty_id { get; set; }

        

    }
}
