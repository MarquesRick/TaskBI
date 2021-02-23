using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentdailymetricsCommun : AgentdailymetricsBase
    {
        #region Singleton

        private static AgentdailymetricsCommun _instance = null;

        public AgentdailymetricsCommun()
        {
        }

        public static AgentdailymetricsCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentdailymetricsCommun();

            return _instance;
        }
        #endregion
    }
}
