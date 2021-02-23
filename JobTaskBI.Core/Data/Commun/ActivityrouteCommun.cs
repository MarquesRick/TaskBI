using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ActivityrouteCommun : ActivityrouteBase
    {
        #region Singleton

        private static ActivityrouteCommun _instance = null;

        public ActivityrouteCommun()
        {
        }

        public static ActivityrouteCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ActivityrouteCommun();

            return _instance;
        }
        #endregion
    }
}
