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
    public class WorkjourneyBase
    {
        #region Constructor
        public WorkjourneyBase()
        {

        }
        #endregion

        #region Methods

        public IList<Workjourney> Get(Workjourney workjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(workjourney);
            IList<Workjourney> response = ConNpgSqlDAL<Workjourney>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Workjourney> Get(Workjourney workjourney, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(workjourney, paged, total, page_quantity, page_number);
            IList<Workjourney> response = ConNpgSqlDAL<Workjourney>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Workjourney workjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(workjourney);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Workjourney> GetCombo(Workjourney workjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(workjourney);
            IList<Workjourney> response = ConNpgSqlDAL<Workjourney>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Workjourney workjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(workjourney);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Workjourney workjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(workjourney);
            ConNpgSqlDAL<Workjourney>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Workjourney workjourney)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(workjourney);
            ConNpgSqlDAL<Workjourney>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            