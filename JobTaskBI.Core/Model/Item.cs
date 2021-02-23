using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Item
    {
        [_MapperTO("ITE_ID")]
        public int ite_id { get; set; }

        [_MapperTO("ITE_INTEGRATIONID")]
        public string ite_integrationid { get; set; }

        [_MapperTO("ITE_DESCRIPTION")]
        public string ite_description { get; set; }

        [_MapperTO("ITE_ACTIVE")]
        public string ite_active { get; set; }

        [_MapperTO("ISG_ID")]
        public int isg_id { get; set; }

        [_MapperTO("ICY_ID")]
        public int icy_id { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("AGE_ID_INSERT")]
        public int age_id_insert { get; set; }

        [_MapperTO("ITE_DATETIMEINSERT")]
        public int ite_datetimeinsert { get; set; }

        [_MapperTO("ITE_MODULEINSERT")]
        public string ite_moduleinsert { get; set; }

        [_MapperTO("AGE_ID_LASTUPDATE")]
        public int age_id_lastupdate { get; set; }

        [_MapperTO("ITE_DATETIMELASTUPDATE")]
        public int ite_datetimelastupdate { get; set; }

        [_MapperTO("ITE_MODULELASTUPDATE")]
        public string ite_modulelastupdate { get; set; }

       



    }
}
