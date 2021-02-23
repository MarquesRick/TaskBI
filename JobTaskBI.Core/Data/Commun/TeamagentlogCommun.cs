using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TeamagentlogCommun : TeamagentlogBase
    {
        #region Singleton

        private static TeamagentlogCommun _instance = null;

        public TeamagentlogCommun()
        {
        }

        public static TeamagentlogCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TeamagentlogCommun();

            return _instance;
        }
        #endregion
    }
}
