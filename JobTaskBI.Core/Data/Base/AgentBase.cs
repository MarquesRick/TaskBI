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
    public class AgentBase
    {
        #region Constructor
        public AgentBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agent> Get(Agent agent)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agent);
            IList<Agent> response = ConNpgSqlDAL<Agent>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agent> Get(Agent agent, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agent, paged, total, page_quantity, page_number);
            IList<Agent> response = ConNpgSqlDAL<Agent>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agent agent)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agent);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agent> GetCombo(Agent agent)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agent);
            IList<Agent> response = ConNpgSqlDAL<Agent>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agent agent)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agent);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agent agent)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agent);
            ConNpgSqlDAL<Agent>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agent agent)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agent);
            ConNpgSqlDAL<Agent>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            