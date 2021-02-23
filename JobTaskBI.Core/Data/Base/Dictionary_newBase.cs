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
    public class Dictionary_newBase
    {
        #region Constructor
        public Dictionary_newBase()
        {

        }
        #endregion

        #region Methods

        public IList<Dictionary_new> Get(Dictionary_new dictionary_new)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(dictionary_new);
            IList<Dictionary_new> response = ConNpgSqlDAL<Dictionary_new>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Dictionary_new> Get(Dictionary_new dictionary_new, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(dictionary_new, paged, total, page_quantity, page_number);
            IList<Dictionary_new> response = ConNpgSqlDAL<Dictionary_new>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Dictionary_new dictionary_new)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(dictionary_new);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Dictionary_new> GetCombo(Dictionary_new dictionary_new)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(dictionary_new);
            IList<Dictionary_new> response = ConNpgSqlDAL<Dictionary_new>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Dictionary_new dictionary_new)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(dictionary_new);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Dictionary_new dictionary_new)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(dictionary_new);
            ConNpgSqlDAL<Dictionary_new>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Dictionary_new dictionary_new)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(dictionary_new);
            ConNpgSqlDAL<Dictionary_new>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            