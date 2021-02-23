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
    public class TaskBase
    {
        #region Constructor
        public TaskBase()
        {

        }
        #endregion

        #region Methods

        public IList<Task> Get(Task task)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(task);
            IList<Task> response = ConNpgSqlDAL<Task>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Task> Get(Task task, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(task, paged, total, page_quantity, page_number);
            IList<Task> response = ConNpgSqlDAL<Task>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Task task)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(task);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Task> GetCombo(Task task)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(task);
            IList<Task> response = ConNpgSqlDAL<Task>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Task task)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(task);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Task task)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(task);
            ConNpgSqlDAL<Task>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Task task)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(task);
            ConNpgSqlDAL<Task>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            