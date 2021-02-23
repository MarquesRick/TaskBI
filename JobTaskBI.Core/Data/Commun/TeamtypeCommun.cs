using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TeamtypeCommun : TeamtypeBase
    {
        #region Singleton

        private static TeamtypeCommun _instance = null;

        public TeamtypeCommun()
        {
        }

        public static TeamtypeCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TeamtypeCommun();

            return _instance;
        }
        #endregion
    }
}
