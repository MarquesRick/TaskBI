using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Activityroute
    {
        [_MapperTO("ACR_ID")]
        public int acr_id { get; set; }

        [_MapperTO("ROT_ID")]
        public int rot_id { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }


    }
}
