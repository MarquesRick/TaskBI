using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TeamCommun : TeamBase
    {
        #region Singleton

        private static TeamCommun _instance = null;

        public TeamCommun()
        {
        }

        public static TeamCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TeamCommun();

            return _instance;
        }
        #endregion
    }
}
