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
    public class TasktypeBase
    {
        #region Constructor
        public TasktypeBase()
        {

        }
        #endregion

        #region Methods

        public IList<Tasktype> Get(Tasktype tasktype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(tasktype);
            IList<Tasktype> response = ConNpgSqlDAL<Tasktype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Tasktype> Get(Tasktype tasktype, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(tasktype, paged, total, page_quantity, page_number);
            IList<Tasktype> response = ConNpgSqlDAL<Tasktype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Tasktype tasktype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(tasktype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Tasktype> GetCombo(Tasktype tasktype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(tasktype);
            IList<Tasktype> response = ConNpgSqlDAL<Tasktype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Tasktype tasktype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(tasktype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Tasktype tasktype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(tasktype);
            ConNpgSqlDAL<Tasktype>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Tasktype tasktype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(tasktype);
            ConNpgSqlDAL<Tasktype>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            