using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TaskactivityCommun : TaskactivityBase
    {
        #region Singleton

        private static TaskactivityCommun _instance = null;

        public TaskactivityCommun()
        {
        }

        public static TaskactivityCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TaskactivityCommun();

            return _instance;
        }
        #endregion
    }
}
