using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ActivityCommun : ActivityBase
    {
        #region Singleton

        private static ActivityCommun _instance = null;

        public ActivityCommun()
        {
        }

        public static ActivityCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ActivityCommun();

            return _instance;
        }
        #endregion
    }
}
