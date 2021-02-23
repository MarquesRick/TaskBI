using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TaskitemCommun : TaskitemBase
    {
        #region Singleton

        private static TaskitemCommun _instance = null;

        public TaskitemCommun()
        {
        }

        public static TaskitemCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TaskitemCommun();

            return _instance;
        }
        #endregion
    }
}
