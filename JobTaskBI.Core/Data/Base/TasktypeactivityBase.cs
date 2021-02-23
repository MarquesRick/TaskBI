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
    public class TasktypeactivityBase
    {
        #region Constructor
        public TasktypeactivityBase()
        {

        }
        #endregion

        #region Methods

        public IList<Tasktypeactivity> Get(Tasktypeactivity tasktypeactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(tasktypeactivity);
            IList<Tasktypeactivity> response = ConNpgSqlDAL<Tasktypeactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Tasktypeactivity> Get(Tasktypeactivity tasktypeactivity, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(tasktypeactivity, paged, total, page_quantity, page_number);
            IList<Tasktypeactivity> response = ConNpgSqlDAL<Tasktypeactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Tasktypeactivity tasktypeactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(tasktypeactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Tasktypeactivity> GetCombo(Tasktypeactivity tasktypeactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(tasktypeactivity);
            IList<Tasktypeactivity> response = ConNpgSqlDAL<Tasktypeactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Tasktypeactivity tasktypeactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(tasktypeactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Tasktypeactivity tasktypeactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(tasktypeactivity);
            ConNpgSqlDAL<Tasktypeactivity>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Tasktypeactivity tasktypeactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(tasktypeactivity);
            ConNpgSqlDAL<Tasktypeactivity>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            