using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Task
    {
        [_MapperTO("TSK_ID")]
        public int tsk_id { get; set; }

        [_MapperTO("TSK_INTEGRATIONID")]
        public string tsk_integrationid { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("LOC_ID")]
        public int loc_id { get; set; }

        [_MapperTO("TSK_SCHEDULEINITIALDATEHOUR")]
        public int tsk_scheduleinitialdatehour { get; set; }

        [_MapperTO("TSK_REALINITIALDATEHOUR")]
        public int tsk_realinitialdatehour { get; set; }

        [_MapperTO("TSK_SCHEDULEFINALDATEHOUR")]
        public int tsk_schedulefinaldatehour { get; set; }

        [_MapperTO("TSK_REALFINALDATEHOUR")]
        public int tsk_realfinaldatehour { get; set; }

        [_MapperTO("TSK_LASTEXECUTIONDATEHOUR")]
        public int tsk_lastexecutiondatehour { get; set; }

        [_MapperTO("TSK_OBSERVATION")]
        public string tsk_observation { get; set; }

        [_MapperTO("TSK_ACTIVE")]
        public string tsk_active { get; set; }

        [_MapperTO("TSK_SITUATION")]
        public string tsk_situation { get; set; }

        [_MapperTO("TSK_AUTOMATICCLOSINGAPP")]
        public int tsk_automaticclosingapp { get; set; }

        [_MapperTO("TSK_EXPECTEDFINALDATEHOUR")]
        public int tsk_expectedfinaldatehour { get; set; }

        [_MapperTO("TSS_ID")]
        public string tss_id { get; set; }

        [_MapperTO("TSK_WAITINGTIME")]
        public int tsk_waitingtime { get; set; }

        [_MapperTO("TSK_PRIORITY")]
        public int tsk_priority { get; set; }

        [_MapperTO("TSK_SOURCE")]
        public string tsk_source { get; set; }

        [_MapperTO("MED_ID")]
        public int med_id { get; set; }

        [_MapperTO("TEA_ID")]
        public int manufacturetea_idr { get; set; }

        [_MapperTO("TSK_ACTIVITYORIGIN")]
        public string tsk_activityorigin { get; set; }

        [_MapperTO("TSK_PRESTARTALERT")]
        public int tsk_prestartalert { get; set; }

        [_MapperTO("TSK_POSSTARTALERT")]
        public int tsk_posstartalert { get; set; }

        [_MapperTO("TSK_PRESTARTBLOCK")]
        public int tsk_prestartblock { get; set; }

        [_MapperTO("TSK_POSSTARTBLOCK")]
        public int tsk_posstartblock { get; set; }

        [_MapperTO("TSK_PREENDALERT")]
        public int tsk_preendalert { get; set; }

        [_MapperTO("TSK_POSENDALERT")]
        public int tsk_posendalert { get; set; }

        [_MapperTO("TSK_INSERTDATEHOUR")]
        public int tsk_insertdatehour { get; set; }

        [_MapperTO("TSK_LASTMODIFICATION")]
        public int tsk_lastmodification { get; set; }

        [_MapperTO("TSK_MOBILESENDDATE")]
        public int tsk_mobilesenddate { get; set; }

        [_MapperTO("TSK_ACCESSTOKEN")]
        public int tsk_accesstoken { get; set; }

        [_MapperTO("AGE_ID_INSERT")]
        public int age_id_insert { get; set; }

        [_MapperTO("TSK_DATETIMEINSERT")]
        public int tsk_datetimeinsert { get; set; }

        [_MapperTO("TSK_MODULEINSERT")]
        public string tsk_moduleinsert { get; set; }

        [_MapperTO("AGE_ID_LASTUPDATE")]
        public int age_id_lastupdate { get; set; }

        [_MapperTO("TSK_DATETIMELASTUPDATE")]
        public int tsk_datetimelastupdate { get; set; }

        [_MapperTO("TSK_MODULELASTUPDATE")]
        public string tsk_modulelastupdate { get; set; }

        [_MapperTO("TTY_ID")]
        public int tty_id { get; set; }

        [_MapperTO("TSK_EXECUTIONERROR")]
        public string tsk_executionerror { get; set; }

        [_MapperTO("TSK_GROUP")]
        public string tsk_group { get; set; }

        [_MapperTO("TSK_NEGATIVEEXECUTION")]
        public string tsk_negativeexecution { get; set; }

        [_MapperTO("TSK_FILTERFIELD1")]
        public string tsk_filterfield1 { get; set; }

        [_MapperTO("TSK_FILTERFIELD2")]
        public string tsk_filterfield2 { get; set; }

        [_MapperTO("TSK_FILTERFIELD3")]
        public string tsk_filterfield3 { get; set; }

        [_MapperTO("TSK_ACTIVITYORIGINLIST")]
        public string tsk_activityoriginlist { get; set; }


    }
}
