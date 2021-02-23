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
    public class AgentdailystatisticsBase
    {
        #region Constructor
        public AgentdailystatisticsBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentdailystatistics> Get(Agentdailystatistics agentdailystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailystatistics);
            IList<Agentdailystatistics> response = ConNpgSqlDAL<Agentdailystatistics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentdailystatistics> Get(Agentdailystatistics agentdailystatistics, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailystatistics, paged, total, page_quantity, page_number);
            IList<Agentdailystatistics> response = ConNpgSqlDAL<Agentdailystatistics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentdailystatistics agentdailystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agentdailystatistics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

      
        public IList<Agentdailystatistics> GetCombo(Agentdailystatistics agentdailystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agentdailystatistics);
            IList<Agentdailystatistics> response = ConNpgSqlDAL<Agentdailystatistics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentdailystatistics agentdailystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agentdailystatistics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentdailystatistics agentdailystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agentdailystatistics);
            ConNpgSqlDAL<Agentdailystatistics>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentdailystatistics agentdailystatistics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agentdailystatistics);
            ConNpgSqlDAL<Agentdailystatistics>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            