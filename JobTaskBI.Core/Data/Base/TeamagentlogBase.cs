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
    public class TeamagentlogBase
    {
        #region Constructor
        public TeamagentlogBase()
        {

        }
        #endregion

        #region Methods

        public IList<Teamagentlog> Get(Teamagentlog teamagentlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(teamagentlog);
            IList<Teamagentlog> response = ConNpgSqlDAL<Teamagentlog>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Teamagentlog> Get(Teamagentlog teamagentlog, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(teamagentlog, paged, total, page_quantity, page_number);
            IList<Teamagentlog> response = ConNpgSqlDAL<Teamagentlog>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Teamagentlog teamagentlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(teamagentlog);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Teamagentlog> GetCombo(Teamagentlog teamagentlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(teamagentlog);
            IList<Teamagentlog> response = ConNpgSqlDAL<Teamagentlog>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Teamagentlog teamagentlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(teamagentlog);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Teamagentlog teamagentlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(teamagentlog);
            ConNpgSqlDAL<Teamagentlog>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Teamagentlog teamagentlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(teamagentlog);
            ConNpgSqlDAL<Teamagentlog>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            