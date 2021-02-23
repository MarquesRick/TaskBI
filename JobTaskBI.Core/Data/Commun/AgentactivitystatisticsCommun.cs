using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentactivitystatisticsCommun : AgentactivitystatisticsBase
    {
        #region Singleton

        private static AgentactivitystatisticsCommun _instance = null;

        public AgentactivitystatisticsCommun()
        {
        }

        public static AgentactivitystatisticsCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentactivitystatisticsCommun();

            return _instance;
        }
        #endregion
    }
}
