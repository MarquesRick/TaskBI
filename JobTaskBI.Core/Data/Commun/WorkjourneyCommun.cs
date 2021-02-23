using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class WorkjourneyCommun : WorkjourneyBase
    {
        #region Singleton

        private static WorkjourneyCommun _instance = null;

        public WorkjourneyCommun()
        {
        }

        public static WorkjourneyCommun GetInstance()
        {
            if (_instance == null)
                _instance = new WorkjourneyCommun();

            return _instance;
        }
        #endregion
    }
}
