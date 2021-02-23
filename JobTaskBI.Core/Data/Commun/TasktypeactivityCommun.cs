using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TasktypeactivityCommun : TasktypeactivityBase
    {
        #region Singleton

        private static TasktypeactivityCommun _instance = null;

        public TasktypeactivityCommun()
        {
        }

        public static TasktypeactivityCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TasktypeactivityCommun();

            return _instance;
        }
        #endregion
    }
}
