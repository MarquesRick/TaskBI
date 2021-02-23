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
    public class ActivityfieldBase
    {
        #region Constructor
        public ActivityfieldBase()
        {

        }
        #endregion

        #region Methods

        public IList<Activityfield> Get(Activityfield activityfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activityfield);
            IList<Activityfield> response = ConNpgSqlDAL<Activityfield>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activityfield> Get(Activityfield activityfield, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activityfield, paged, total, page_quantity, page_number);
            IList<Activityfield> response = ConNpgSqlDAL<Activityfield>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Activityfield activityfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(activityfield);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Activityfield> GetCombo(Activityfield activityfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(activityfield);
            IList<Activityfield> response = ConNpgSqlDAL<Activityfield>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Activityfield activityfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(activityfield);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Activityfield activityfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(activityfield);
            ConNpgSqlDAL<Activityfield>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Activityfield activityfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(activityfield);
            ConNpgSqlDAL<Activityfield>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            