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
    public class TaskitemBase
    {
        #region Constructor
        public TaskitemBase()
        {

        }
        #endregion

        #region Methods

        public IList<Taskitem> Get(Taskitem taskitem)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(taskitem);
            IList<Taskitem> response = ConNpgSqlDAL<Taskitem>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Taskitem> Get(Taskitem taskitem, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(taskitem, paged, total, page_quantity, page_number);
            IList<Taskitem> response = ConNpgSqlDAL<Taskitem>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Taskitem taskitem)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(taskitem);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

      

        public IList<Taskitem> GetCombo(Taskitem taskitem)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(taskitem);
            IList<Taskitem> response = ConNpgSqlDAL<Taskitem>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Taskitem taskitem)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(taskitem);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Taskitem taskitem)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(taskitem);
            ConNpgSqlDAL<Taskitem>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Taskitem taskitem)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(taskitem);
            ConNpgSqlDAL<Taskitem>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            