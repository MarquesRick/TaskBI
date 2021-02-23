using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentdailymetrics
    {
        [_MapperTO("ADM_ID")]
        public int adm_id { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("ADM_METRICDATE")]
        public int adm_metricdate { get; set; }

        [_MapperTO("ADM_INITIALEXECUTIONHOUR")]
        public int adm_initialexecutionhour { get; set; }

        [_MapperTO("ADM_FINALEXECUTIONHOUR")]
        public int adm_finalexecutionhour { get; set; }

        [_MapperTO("ADM_TOTALEXECUTEDTASKTIME")]
        public int adm_totalexecutedtasktime { get; set; }

        [_MapperTO("ADM_TOTALUNEXECUTEDTASKTIME")]
        public int adm_totalunexecutedtasktime { get; set; }

        [_MapperTO("ADM_TOTALWORKEDTIME")]
        public int adm_totalworkedtime { get; set; }

        [_MapperTO("ADM_TOTALUNWORKEDTIME")]
        public int adm_totalunworkedtime { get; set; }

        [_MapperTO("ADM_TOTALTRAVELEDDISTANCE")]
        public int adm_totaltraveleddistance { get; set; }

        [_MapperTO("ADM_TOTALEXECUTEDTASKS")]
        public int adm_totalexecutedtasks { get; set; }

        [_MapperTO("ADM_TOTALNEGATIVESTASKS")]
        public int adm_totalnegativestasks { get; set; }

        [_MapperTO("ADM_TOTALEXECUTEDACTIVITIES")]
        public int adm_totalexecutedactivities { get; set; }

        [_MapperTO("ADM_TOTALPLANNEDTIME")]
        public int adm_totalplannedtime { get; set; }

        [_MapperTO("ADM_TOTALJOURNEYTIME")]
        public int adm_totaljourneytime { get; set; }

        [_MapperTO("ADM_TOTALPERFORMEDTIME")]
        public int adm_totalperformedtime { get; set; }

        [_MapperTO("ADM_TOTALDIFERENCETIME")]
        public int adm_totaldiferencetime { get; set; }

        [_MapperTO("ADM_TOTALBREAKTIME")]
        public int adm_totalbreaktime { get; set; }

        [_MapperTO("ADM_TOTALSTOPPINGTIME")]
        public int adm_totalstoppingtime { get; set; }

        [_MapperTO("ADM_TOTALRESTTIME")]
        public int adm_totalresttime { get; set; }

        [_MapperTO("ADM_LOGGEDINMOBILE")]
        public int adm_loggedinmobile { get; set; }

        [_MapperTO("ADM_TOTALSCHEDULEDTASKS")]
        public int adm_totalscheduledtasks { get; set; }

        [_MapperTO("ADM_TOTALCANCELEDTASKS")]
        public int adm_totalcanceledtasks { get; set; }

        [_MapperTO("ADM_TOTALINACTIVATEDTASKS")]
        public int adm_totalinactivatedtasks { get; set; }

        [_MapperTO("ADM_TOTALUNEXECUTEDTASKTIMEOPTIMIZED")]
        public int adm_totalunexecutedtasktimeoptimized { get; set; }

        [_MapperTO("ADM_TOTALTRAVELEDDISTANCEOPTIMIZED")]
        public int adm_totaltraveleddistanceoptimized { get; set; }

    }
}
