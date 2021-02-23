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
    public class TeamagentBase
    {
        #region Constructor
        public TeamagentBase()
        {

        }
        #endregion

        #region Methods

        public IList<Teamagent> Get(Teamagent teamagent)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(teamagent);
            IList<Teamagent> response = ConNpgSqlDAL<Teamagent>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Teamagent> Get(Teamagent teamagent, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(teamagent, paged, total, page_quantity, page_number);
            IList<Teamagent> response = ConNpgSqlDAL<Teamagent>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Teamagent teamagent)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(teamagent);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Teamagent> GetCombo(Teamagent teamagent)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(teamagent);
            IList<Teamagent> response = ConNpgSqlDAL<Teamagent>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Teamagent teamagent)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(teamagent);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Teamagent teamagent)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(teamagent);
            ConNpgSqlDAL<Teamagent>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Teamagent teamagent)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(teamagent);
            ConNpgSqlDAL<Teamagent>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            