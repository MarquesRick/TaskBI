using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class LogCommun : LogBase
    {
        #region Singleton

        private static LogCommun _instance = null;

        public LogCommun()
        {
        }

        public static LogCommun GetInstance()
        {
            if (_instance == null)
                _instance = new LogCommun();

            return _instance;
        }
        #endregion
    }
}
