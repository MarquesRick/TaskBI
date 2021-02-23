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
    public class TeamBase
    {
        #region Constructor
        public TeamBase()
        {

        }
        #endregion

        #region Methods

        public IList<Team> Get(Team team)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(team);
            IList<Team> response = ConNpgSqlDAL<Team>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Team> Get(Team team, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(team, paged, total, page_quantity, page_number);
            IList<Team> response = ConNpgSqlDAL<Team>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Team team)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(team);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        
        

        public IList<Team> GetCombo(Team team)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(team);
            IList<Team> response = ConNpgSqlDAL<Team>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Team team)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(team);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Team team)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(team);
            ConNpgSqlDAL<Team>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Team team)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(team);
            ConNpgSqlDAL<Team>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            