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
    public class AgentgroupBase
    {
        #region Constructor
        public AgentgroupBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentgroup> Get(Agentgroup device)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(device);
            IList<Agentgroup> response = ConNpgSqlDAL<Agentgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentgroup> Get(Agentgroup device, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(device, paged, total, page_quantity, page_number);
            IList<Agentgroup> response = ConNpgSqlDAL<Agentgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentgroup device)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(device);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Agentgroup> GetCombo(Agentgroup device)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(device);
            IList<Agentgroup> response = ConNpgSqlDAL<Agentgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentgroup device)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(device);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentgroup device)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(device);
            ConNpgSqlDAL<Agentgroup>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentgroup device)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(device);
            ConNpgSqlDAL<Agentgroup>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            