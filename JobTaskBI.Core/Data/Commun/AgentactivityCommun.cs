using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentactivityCommun : AgentactivityBase
    {
        #region Singleton

        private static AgentactivityCommun _instance = null;

        public AgentactivityCommun()
        {
        }

        public static AgentactivityCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentactivityCommun();

            return _instance;
        }
        #endregion
    }
}
