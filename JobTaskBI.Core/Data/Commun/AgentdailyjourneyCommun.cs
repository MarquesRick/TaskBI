using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentdailyjourneyCommun : AgentdailyjourneyBase
    {
        #region Singleton

        private static AgentdailyjourneyCommun _instance = null;

        public AgentdailyjourneyCommun()
        {
        }

        public static AgentdailyjourneyCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentdailyjourneyCommun();

            return _instance;
        }
        #endregion
    }
}
