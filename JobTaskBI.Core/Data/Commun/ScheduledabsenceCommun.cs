using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ScheduledabsenceCommun : ScheduledabsenceBase
    {
        #region Singleton

        private static ScheduledabsenceCommun _instance = null;

        public ScheduledabsenceCommun()
        {
        }

        public static ScheduledabsenceCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ScheduledabsenceCommun();

            return _instance;
        }
        #endregion
    }
}
