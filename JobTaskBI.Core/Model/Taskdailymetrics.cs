using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Taskdailymetrics
    {
        [_MapperTO("TDM_ID")]
        public int tdm_id { get; set; }

        [_MapperTO("TSK_ID")]
        public int tsk_id { get; set; }

        [_MapperTO("TDM_DATE")]
        public int tdm_date { get; set; }

        [_MapperTO("TDM_INITIALEXECUTIONDATEHOUR")]
        public int tdm_initialexecutiondatehour { get; set; }

        [_MapperTO("TDM_FINALEXECUTIONDATEHOUR")]
        public int tdm_finalexecutiondatehour { get; set; }

        [_MapperTO("TDM_TOTALEXECUTEDTASKTIME")]
        public int tdm_totalexecutedtasktime { get; set; }

        [_MapperTO("TDM_TOTALUNEXECUTEDTASKTIME")]
        public int tdm_totalunexecutedtasktime { get; set; }

        [_MapperTO("TDM_TOTALWORKEDTIME")]
        public int tdm_totalworkedtime { get; set; }

        [_MapperTO("TDM_TOTALUNWORKEDTIME")]
        public int tdm_totalunworkedtime { get; set; }

        [_MapperTO("TDM_TOTALTRAVELEDDISTANCE")]
        public int tdm_totaltraveleddistance { get; set; }

        [_MapperTO("TDM_NEGATIVETASK")]
        public string tdm_negativetask { get; set; }

        [_MapperTO("TDM_TOTALEXECUTEDACTIVITIES")]
        public int tdm_totalexecutedactivities { get; set; }

        [_MapperTO("TDM_EXECUTIONHOURERRORS")]
        public string tdm_executionhourerrors { get; set; }

        [_MapperTO("TDM_TOTALUNEXECUTEDTASKTIMEOPTIMIZED")]
        public int tdm_totalunexecutedtasktimeoptimized { get; set; }

        [_MapperTO("TDM_TOTALTRAVELEDDISTANCEOPTIMIZED")]
        public int tdm_totaltraveleddistanceoptimized { get; set; }

        [_MapperTO("TDM_LOCALGEOPOSITION")]
        public string tdm_localgeoposition { get; set; }

    }
}
