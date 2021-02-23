using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ActivitysectionCommun : ActivitysectionBase
    {
        #region Singleton

        private static ActivitysectionCommun _instance = null;

        public ActivitysectionCommun()
        {
        }

        public static ActivitysectionCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ActivitysectionCommun();

            return _instance;
        }
        #endregion
    }
}
