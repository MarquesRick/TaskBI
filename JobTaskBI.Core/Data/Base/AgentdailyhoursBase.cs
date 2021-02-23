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
    public class AgentdailyhoursBase
    {
        #region Constructor
        public AgentdailyhoursBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentdailyhours> Get(Agentdailyhours agentdailyhours)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailyhours);
            IList<Agentdailyhours> response = ConNpgSqlDAL<Agentdailyhours>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentdailyhours> Get(Agentdailyhours agentdailyhours, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentdailyhours, paged, total, page_quantity, page_number);
            IList<Agentdailyhours> response = ConNpgSqlDAL<Agentdailyhours>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentdailyhours agentdailyhours)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agentdailyhours);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentdailyhours> GetCombo(Agentdailyhours agentdailyhours)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agentdailyhours);
            IList<Agentdailyhours> response = ConNpgSqlDAL<Agentdailyhours>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentdailyhours agentdailyhours)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agentdailyhours);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentdailyhours agentdailyhours)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agentdailyhours);
            ConNpgSqlDAL<Agentdailyhours>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentdailyhours agentdailyhours)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agentdailyhours);
            ConNpgSqlDAL<Agentdailyhours>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            