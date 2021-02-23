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
    public class ActivityrouteBase
    {
        #region Constructor
        public ActivityrouteBase()
        {

        }
        #endregion

        #region Methods

        public IList<Activityroute> Get(Activityroute activityroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activityroute);
            IList<Activityroute> response = ConNpgSqlDAL<Activityroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activityroute> Get(Activityroute activityroute, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activityroute, paged, total, page_quantity, page_number);
            IList<Activityroute> response = ConNpgSqlDAL<Activityroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Activityroute activityroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(activityroute);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Activityroute> GetCombo(Activityroute activityroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(activityroute);
            IList<Activityroute> response = ConNpgSqlDAL<Activityroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Activityroute activityroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(activityroute);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Activityroute activityroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(activityroute);
            ConNpgSqlDAL<Activityroute>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Activityroute activityroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(activityroute);
            ConNpgSqlDAL<Activityroute>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            