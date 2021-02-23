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
    public class AgentrouteBase
    {
        #region Constructor
        public AgentrouteBase()
        {

        }
        #endregion

        #region Methods

        public IList<Agentroute> Get(Agentroute agentroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentroute);
            IList<Agentroute> response = ConNpgSqlDAL<Agentroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Agentroute> Get(Agentroute agentroute, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(agentroute, paged, total, page_quantity, page_number);
            IList<Agentroute> response = ConNpgSqlDAL<Agentroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Agentroute agentroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(agentroute);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Agentroute> GetCombo(Agentroute agentroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(agentroute);
            IList<Agentroute> response = ConNpgSqlDAL<Agentroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Agentroute agentroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(agentroute);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Agentroute agentroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(agentroute);
            ConNpgSqlDAL<Agentroute>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Agentroute agentroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(agentroute);
            ConNpgSqlDAL<Agentroute>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            