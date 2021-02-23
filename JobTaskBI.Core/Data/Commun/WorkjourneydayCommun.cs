using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class WorkjourneydayCommun : WorkjourneydayBase
    {
        #region Singleton

        private static WorkjourneydayCommun _instance = null;

        public WorkjourneydayCommun()
        {
        }

        public static WorkjourneydayCommun GetInstance()
        {
            if (_instance == null)
                _instance = new WorkjourneydayCommun();

            return _instance;
        }
        #endregion
    }
}
