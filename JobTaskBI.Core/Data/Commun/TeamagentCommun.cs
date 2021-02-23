using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TeamagentCommun : TeamagentBase
    {
        #region Singleton

        private static TeamagentCommun _instance = null;

        public TeamagentCommun()
        {
        }

        public static TeamagentCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TeamagentCommun();

            return _instance;
        }
        #endregion
    }
}
