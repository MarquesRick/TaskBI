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
    public class RouteBase
    {
        #region Constructor
        public RouteBase()
        {

        }
        #endregion

        #region Methods

        public IList<Route> Get(Route route)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(route);
            IList<Route> response = ConNpgSqlDAL<Route>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Route> Get(Route route, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(route, paged, total, page_quantity, page_number);
            IList<Route> response = ConNpgSqlDAL<Route>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Route route)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(route);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

      
        public IList<Route> GetCombo(Route route)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(route);
            IList<Route> response = ConNpgSqlDAL<Route>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Route route)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(route);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Route route)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(route);
            ConNpgSqlDAL<Route>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Route route)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(route);
            ConNpgSqlDAL<Route>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            