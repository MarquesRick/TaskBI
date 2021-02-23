using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ActivitydefaultCommun : ActivitydefaultBase
    {
        #region Singleton

        private static ActivitydefaultCommun _instance = null;

        public ActivitydefaultCommun()
        {
        }

        public static ActivitydefaultCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ActivitydefaultCommun();

            return _instance;
        }
        #endregion
    }
}
