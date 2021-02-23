using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Tasktype
    {
        [_MapperTO("TTY_ID")]
        public int tty_id { get; set; }

        [_MapperTO("TTY_INTEGRATIONID")]
        public string tty_integrationid { get; set; }

        [_MapperTO("TTY_DESCRIPTION")]
        public string tty_description { get; set; }

        [_MapperTO("TTY_ACTIVE")]
        public string tty_active { get; set; }

       

    }
}
