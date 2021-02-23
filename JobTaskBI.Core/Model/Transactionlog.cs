using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Transactionlog
    {
        [_MapperTO("TRL_ID")]
        public int trl_id { get; set; }

        [_MapperTO("TRL_DATEHOUR")]
        public int trl_datehour { get; set; }

        [_MapperTO("TRL_STATEMENTS")]
        public string trl_statements { get; set; }

        [_MapperTO("TRL_TXID")]
        public int trl_txid { get; set; }

        

    }
}
