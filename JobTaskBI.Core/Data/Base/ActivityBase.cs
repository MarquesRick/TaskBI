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
    public class ActivityBase
    {
        #region Constructor
        public ActivityBase()
        {

        }
        #endregion

        #region Methods

        public IList<Activity> Get(Activity activity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activity);
            IList<Activity> response = ConNpgSqlDAL<Activity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activity> Get(Activity activity, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activity, paged, total, page_quantity, page_number);
            IList<Activity> response = ConNpgSqlDAL<Activity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Activity activity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(activity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activity> GetCombo(Activity activity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(activity);
            IList<Activity> response = ConNpgSqlDAL<Activity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Activity activity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(activity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Activity activity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(activity);
            ConNpgSqlDAL<Activity>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Activity activity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(activity);
            ConNpgSqlDAL<Activity>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            