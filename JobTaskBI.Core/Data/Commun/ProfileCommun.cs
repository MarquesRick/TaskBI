using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data.Commun
{
    public class ProfileCommun : ProfileBase
    {
        #region Singleton

        private static ProfileCommun _instance = null;

        public ProfileCommun()
        {
        }

        public static ProfileCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ProfileCommun();

            return _instance;
        }
        #endregion
    }
}