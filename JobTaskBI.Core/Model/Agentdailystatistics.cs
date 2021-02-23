using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentdailystatistics
    {
        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("ADS_DATE")]
        public int ads_date { get; set; }

        [_MapperTO("ADS_EXECUTEDTASKS")]
        public int ads_executedtasks { get; set; }

        [_MapperTO("ADS_EXECUTEDACTIVITIES")]
        public int ads_executedactivities { get; set; }

        [_MapperTO("ADS_COLLECTEDIMAGES")]
        public int ads_collectedimages { get; set; }

        [_MapperTO("ADS_EXECUTIONTIME")]
        public int ads_executiontime { get; set; }

        [_MapperTO("ADS_DELAYTIME")]
        public int ads_delaytime { get; set; }

        [_MapperTO("ADS_EXECUTEDLATE")]
        public int ads_executedlate { get; set; }

        [_MapperTO("ADS_EXECUTEDONTIME")]
        public int ads_executedontime { get; set; }

        [_MapperTO("ADS_EXECUTEDEARLY")]
        public int ads_executedearly { get; set; }

        [_MapperTO("ADS_FIRSTSINCRONISM")]
        public int ads_firstsincronism { get; set; }

        [_MapperTO("ADS_WAITTIME")]
        public int ads_waittime { get; set; }

        [_MapperTO("ADS_TRAVELTIME")]
        public int ads_traveltime { get; set; }

        [_MapperTO("ADS_STANDINGTIME")]
        public int ads_standingtime { get; set; }

        [_MapperTO("ADS_TRAVELDISTANCE")]
        public int ads_traveldistance { get; set; }

        [_MapperTO("ADS_DATATRANSMITTED")]
        public int ads_datatransmitted { get; set; }

        [_MapperTO("ADS_CREATEDAT")]
        public int ads_createdat { get; set; }

        [_MapperTO("ADS_LASTUPDATE")]
        public int ads_lastupdate { get; set; }
    }
}
