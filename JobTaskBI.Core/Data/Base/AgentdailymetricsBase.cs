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
    public class AgentdailymetricsBase
    {
        #region Constructor
        public AgentdailymetricsBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentdailymetrics> Get(Agentdailymetrics agentdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailymetrics);
            IList<Agentdailymetrics> response = ConNpgSqlDAL<Agentdailymetrics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentdailymetrics> Get(Agentdailymetrics agentdailymetrics, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailymetrics, paged, total, page_quantity, page_number);
            IList<Agentdailymetrics> response = ConNpgSqlDAL<Agentdailymetrics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentdailymetrics agentdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agentdailymetrics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        

        public IList<Agentdailymetrics> GetCombo(Agentdailymetrics agentdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agentdailymetrics);
            IList<Agentdailymetrics> response = ConNpgSqlDAL<Agentdailymetrics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentdailymetrics agentdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agentdailymetrics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentdailymetrics agentdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agentdailymetrics);
            ConNpgSqlDAL<Agentdailymetrics>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentdailymetrics agentdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agentdailymetrics);
            ConNpgSqlDAL<Agentdailymetrics>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            