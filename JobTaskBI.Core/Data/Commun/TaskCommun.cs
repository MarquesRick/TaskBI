using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TaskCommun : TaskBase
    {
        #region Singleton

        private static TaskCommun _instance = null;

        public TaskCommun()
        {
        }

        public static TaskCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TaskCommun();

            return _instance;
        }
        #endregion
    }
}
