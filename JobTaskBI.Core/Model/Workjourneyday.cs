using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Workjourneyday
    {
        [_MapperTO("WJD_ID")]
        public int wjd_id { get; set; }

        [_MapperTO("WKJ_ID")]
        public int wkj_id { get; set; }

        [_MapperTO("WJD_WEEKDAY")]
        public int wjd_weekday { get; set; }

        [_MapperTO("WJD_INITIALHOUR1")]
        public int wjd_initialhour1 { get; set; }

        [_MapperTO("WJD_FINALHOUR1")]
        public int wjd_finalhour1 { get; set; }

        [_MapperTO("WJD_INITIALHOUR2")]
        public int wjd_initialhour2 { get; set; }

        [_MapperTO("WJD_FINALHOUR2")]
        public int wjd_finalhour2 { get; set; }

        [_MapperTO("USER_IWJD_INITIALHOUR3D")]
        public int wjd_initialhour3 { get; set; }

        [_MapperTO("WJD_FINALHOUR3")]
        public int wjd_finalhour3 { get; set; }

    }
}
