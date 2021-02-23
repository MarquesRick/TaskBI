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
    public class AgentdailyjourneyBase
    {
        #region Constructor
        public AgentdailyjourneyBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentdailyjourney> Get(Agentdailyjourney agentdailyjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailyjourney);
            IList<Agentdailyjourney> response = ConNpgSqlDAL<Agentdailyjourney>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentdailyjourney> Get(Agentdailyjourney agentdailyjourney, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailyjourney, paged, total, page_quantity, page_number);
            IList<Agentdailyjourney> response = ConNpgSqlDAL<Agentdailyjourney>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentdailyjourney agentdailyjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agentdailyjourney);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentdailyjourney> GetCombo(Agentdailyjourney agentdailyjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agentdailyjourney);
            IList<Agentdailyjourney> response = ConNpgSqlDAL<Agentdailyjourney>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentdailyjourney agentdailyjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agentdailyjourney);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentdailyjourney agentdailyjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agentdailyjourney);
            ConNpgSqlDAL<Agentdailyjourney>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentdailyjourney agentdailyjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agentdailyjourney);
            ConNpgSqlDAL<Agentdailyjourney>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            