using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Route
    {
        [_MapperTO("ID_DEVICE")]
        public int rot_id { get; set; }

        [_MapperTO("TOKEN")]
        public string rot_integrationid { get; set; }

        [_MapperTO("MODEL")]
        public string rot_description { get; set; }

        [_MapperTO("MANUFACTURER")]
        public int rot_displayorder { get; set; }

        [_MapperTO("SYSTEM")]
        public string rot_active { get; set; }

        [_MapperTO("VERSION")]
        public string rot_activitysource { get; set; }

        [_MapperTO("ACTIVE")]
        public string rot_agentrelationship { get; set; }

        [_MapperTO("USER_ID")]
        public string rot_activityrelationship { get; set; }

        [_MapperTO("ID_DEVICE")]
        public int tty_id { get; set; }

        [_MapperTO("TOKEN")]
        public string rot_activitysourcelist { get; set; }

        [_MapperTO("MODEL")]
        public string rot_monday { get; set; }

        [_MapperTO("MANUFACTURER")]
        public string rot_tuesday { get; set; }

        [_MapperTO("SYSTEM")]
        public string rot_wednesday { get; set; }

        [_MapperTO("VERSION")]
        public string rot_thursday { get; set; }

        [_MapperTO("ACTIVE")]
        public string rot_friday { get; set; }

        [_MapperTO("USER_ID")]
        public string rot_saturday { get; set; }

        [_MapperTO("USER_ID")]
        public string rot_sunday { get; set; }

    }
}
