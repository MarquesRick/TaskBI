using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentdailyhoursCommun : AgentdailyhoursBase
    {
        #region Singleton

        private static AgentdailyhoursCommun _instance = null;

        public AgentdailyhoursCommun()
        {
        }

        public static AgentdailyhoursCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentdailyhoursCommun();

            return _instance;
        }
        #endregion
    }
}
