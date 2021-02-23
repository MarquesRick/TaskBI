using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentdailystatisticsCommun : AgentdailystatisticsBase
    {
        #region Singleton

        private static AgentdailystatisticsCommun _instance = null;

        public AgentdailystatisticsCommun()
        {
        }

        public static AgentdailystatisticsCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentdailystatisticsCommun();

            return _instance;
        }
        #endregion
    }
}
