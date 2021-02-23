using System.Collections.Generic;
using Core.Model;
using System.Data;
using Core.DAL;
using DbBase;


namespace Core.Data.Base
{
    ////////////////////////////////////////////
    //////// Codigo Gerado  ////////////////////
    ////////////////////////////////////////////
    public class AgentactivitystatisticsBase
    {
        #region Constructor
        public AgentactivitystatisticsBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentactivitystatistics> Get(Agentactivitystatistics agentactivitystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentactivitystatistics);
            IList<Agentactivitystatistics> response = ConNpgSqlDAL<Agentactivitystatistics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentactivitystatistics> Get(Agentactivitystatistics agentactivitystatistics, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentactivitystatistics, paged, total, page_quantity, page_number);
            IList<Agentactivitystatistics> response = ConNpgSqlDAL<Agentactivitystatistics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentactivitystatistics agentactivitystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agentactivitystatistics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentactivitystatistics> GetCombo(Agentactivitystatistics agentactivitystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agentactivitystatistics);
            IList<Agentactivitystatistics> response = ConNpgSqlDAL<Agentactivitystatistics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentactivitystatistics agentactivitystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agentactivitystatistics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentactivitystatistics agentactivitystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agentactivitystatistics);
            ConNpgSqlDAL<Agentactivitystatistics>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentactivitystatistics agentactivitystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agentactivitystatistics);
            ConNpgSqlDAL<Agentactivitystatistics>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            