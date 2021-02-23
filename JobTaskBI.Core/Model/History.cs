using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class History
    {
        [_MapperTO("HTY_ID")]
        public int hty_id { get; set; }

        [_MapperTO("TSK_ID")]
        public int tsk_id { get; set; }

        [_MapperTO("ACT_ID")]
        public int act_id { get; set; }

        [_MapperTO("HTY_INITIALDATEHOUR")]
        public int hty_initialdatehour { get; set; }

        [_MapperTO("HTY_FINALDATEHOUR")]
        public int hty_finaldatehour { get; set; }

        [_MapperTO("HTY_STATUS")]
        public string hty_status { get; set; }

        [_MapperTO("HTY_SYNCDATEHOUR")]
        public string hty_syncdatehour { get; set; }

        [_MapperTO("HTY_APPROVALSTATUS")]
        public string hty_approvalstatus { get; set; }

        [_MapperTO("HTY_INTEGRATIONSTATUS")]
        public string hty_integrationstatus { get; set; }

        [_MapperTO("HTY_TIMEEXECUTIONERROR")]
        public string hty_timeexecutionerror { get; set; }

        [_MapperTO("HTY_LOCATIONEXECUTIONERROR")]
        public string hty_locationexecutionerror { get; set; }

        [_MapperTO("HTY_DATAEXECUTIONERROR")]
        public string hty_dataexecutionerror { get; set; }

        [_MapperTO("HTY_ORIGINALHISTORYID")]
        public int hty_originalhistoryid { get; set; }

        [_MapperTO("HTY_TOTALCAPTUREDMEDIA")]
        public int hty_totalcapturedmedia { get; set; }

        [_MapperTO("HTY_TOTALRECEIVEDMEDIA")]
        public int hty_totalreceivedmedia { get; set; }

    }
}
