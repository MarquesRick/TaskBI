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
    public class AgentactivityBase
    {
        #region Constructor
        public AgentactivityBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentactivity> Get(Agentactivity agentactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentactivity);
            IList<Agentactivity> response = ConNpgSqlDAL<Agentactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentactivity> Get(Agentactivity agentactivity, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentactivity, paged, total, page_quantity, page_number);
            IList<Agentactivity> response = ConNpgSqlDAL<Agentactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentactivity agentactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agentactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentactivity> GetCombo(Agentactivity agentactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agentactivity);
            IList<Agentactivity> response = ConNpgSqlDAL<Agentactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentactivity agentactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agentactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentactivity agentactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agentactivity);
            ConNpgSqlDAL<Agentactivity>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentactivity agentactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agentactivity);
            ConNpgSqlDAL<Agentactivity>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            