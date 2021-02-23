using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TaskdailymetricsCommun : TaskdailymetricsBase
    {
        #region Singleton

        private static TaskdailymetricsCommun _instance = null;

        public TaskdailymetricsCommun()
        {
        }

        public static TaskdailymetricsCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TaskdailymetricsCommun();

            return _instance;
        }
        #endregion
    }
}
