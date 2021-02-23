using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentCommun : AgentBase
    {
        #region Singleton

        private static AgentCommun _instance = null;

        public AgentCommun()
        {
        }

        public static AgentCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentCommun();

            return _instance;
        }
        #endregion
    }
}
