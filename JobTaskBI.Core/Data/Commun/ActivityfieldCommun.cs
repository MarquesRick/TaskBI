using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ActivityfieldCommun : ActivityfieldBase
    {
        #region Singleton

        private static ActivityfieldCommun _instance = null;

        public ActivityfieldCommun()
        {
        }

        public static ActivityfieldCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ActivityfieldCommun();

            return _instance;
        }
        #endregion
    }
}
