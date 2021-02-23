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
    public class Dictionary_new_customerBase
    {
        #region Constructor
        public Dictionary_new_customerBase()
        {

        }
        #endregion

        #region Methods

        public IList<Dictionary_new_customer> Get(Dictionary_new_customer dictionary_new_customer)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(dictionary_new_customer);
            IList<Dictionary_new_customer> response = ConNpgSqlDAL<Dictionary_new_customer>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Dictionary_new_customer> Get(Dictionary_new_customer dictionary_new_customer, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(dictionary_new_customer, paged, total, page_quantity, page_number);
            IList<Dictionary_new_customer> response = ConNpgSqlDAL<Dictionary_new_customer>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Dictionary_new_customer dictionary_new_customer)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(dictionary_new_customer);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Dictionary_new_customer> GetCombo(Dictionary_new_customer dictionary_new_customer)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(dictionary_new_customer);
            IList<Dictionary_new_customer> response = ConNpgSqlDAL<Dictionary_new_customer>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Dictionary_new_customer dictionary_new_customer)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(dictionary_new_customer);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Dictionary_new_customer dictionary_new_customer)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(dictionary_new_customer);
            ConNpgSqlDAL<Dictionary_new_customer>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Dictionary_new_customer dictionary_new_customer)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(dictionary_new_customer);
            ConNpgSqlDAL<Dictionary_new_customer>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            