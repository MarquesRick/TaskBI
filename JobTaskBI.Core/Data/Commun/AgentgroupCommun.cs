using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentgroupCommun : AgentgroupBase
    {
        #region Singleton

        private static AgentgroupCommun _instance = null;

        public AgentgroupCommun()
        {
        }

        public static AgentgroupCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentgroupCommun();

            return _instance;
        }
        #endregion
    }
}
