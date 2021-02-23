using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ActivitytypeCommun : ActivitytypeBase
    {
        #region Singleton

        private static ActivitytypeCommun _instance = null;

        public ActivitytypeCommun()
        {
        }

        public static ActivitytypeCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ActivitytypeCommun();

            return _instance;
        }
        #endregion
    }
}
