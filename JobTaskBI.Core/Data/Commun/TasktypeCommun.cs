using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TasktypeCommun : TasktypeBase
    {
        #region Singleton

        private static TasktypeCommun _instance = null;

        public TasktypeCommun()
        {
        }

        public static TasktypeCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TasktypeCommun();

            return _instance;
        }
        #endregion
    }
}
