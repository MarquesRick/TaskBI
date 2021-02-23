using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Agentdailyjourney
    {
        [_MapperTO("ADJ_ID")]
        public int adj_id { get; set; }

        [_MapperTO("ADM_ID")]
        public int adm_id { get; set; }

        [_MapperTO("ADJ_TOTALPLANNEDHOURS")]
        public int adj_totalplannedhours { get; set; }

        [_MapperTO("ADJ_TOTALEXECUTEDHOURS")]
        public int adj_totalexecutedhours { get; set; }

        [_MapperTO("ADJ_INITIALHOUR1")]
        public int adj_initialhour1 { get; set; }

        [_MapperTO("ADJ_FINALHOUR1")]
        public int adj_finalhour1 { get; set; }

        [_MapperTO("ADJ_INITIALHOUR2")]
        public int adj_initialhour2 { get; set; }

        [_MapperTO("ADJ_FINALHOUR2")]
        public int adj_finalhour2 { get; set; }

        [_MapperTO("ADJ_INITIALHOUR3")]
        public int adj_initialhour3 { get; set; }

        [_MapperTO("ADJ_FINALHOUR3")]
        public int adj_finalhour3 { get; set; }

        [_MapperTO("ADJ_INITIALHOUR4")]
        public int adj_initialhour4 { get; set; }

        [_MapperTO("ADJ_FINALHOUR4")]
        public int adj_finalhour4 { get; set; }

        [_MapperTO("ADJ_INITIALHOUR5")]
        public int adj_initialhour5 { get; set; }

        [_MapperTO("ADJ_FINALHOUR5")]
        public int adj_finalhour5 { get; set; }

        

    }
}
