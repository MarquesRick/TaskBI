using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Customentity
    {
        [_MapperTO("CET_ID")]
        public int cet_id { get; set; }

        [_MapperTO("CET_INTEGRATIONID")]
        public string cet_integrationid { get; set; }

        [_MapperTO("CET_DESCRIPTION")]
        public string cet_description { get; set; }

        [_MapperTO("CET_ACTIVE")]
        public string cet_active { get; set; }

        [_MapperTO("CET_STRUCTURAL")]
        public string cet_structural { get; set; }

        [_MapperTO("CET_STRUCTURALFUNCTION")]
        public string cet_structuralfunction { get; set; }

        [_MapperTO("CET_MYENTITIES")]
        public string cet_myentities { get; set; }

    }
}
