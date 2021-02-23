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
    public class UserBase
    {
        #region Constructor
        public UserBase()
        {

        }
        #endregion

        #region Methods

        public IList<User> Get(User user)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(user);
            IList<User> response = ConNpgSqlDAL<User>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<User> Get(User user, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(user, paged, total, page_quantity, page_number);
            IList<User> response = ConNpgSqlDAL<User>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(User user)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(user);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<User> GetCombo(User user)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(user);
            IList<User> response = ConNpgSqlDAL<User>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(User user)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(user);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(User user)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(user);
            ConNpgSqlDAL<User>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(User user)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(user);
            ConNpgSqlDAL<User>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            