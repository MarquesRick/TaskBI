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
    public class Dictionary_legacyBase
    {
        #region Constructor
        public Dictionary_legacyBase()
        {

        }
        #endregion

        #region Methods

        public IList<Dictionary_legacy> Get(Dictionary_legacy dictionary_legacy)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(dictionary_legacy);
            IList<Dictionary_legacy> response = ConNpgSqlDAL<Dictionary_legacy>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Dictionary_legacy> Get(Dictionary_legacy dictionary_legacy, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(dictionary_legacy, paged, total, page_quantity, page_number);
            IList<Dictionary_legacy> response = ConNpgSqlDAL<Dictionary_legacy>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Dictionary_legacy dictionary_legacy)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(dictionary_legacy);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        
        public IList<Dictionary_legacy> GetCombo(Dictionary_legacy dictionary_legacy)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(dictionary_legacy);
            IList<Dictionary_legacy> response = ConNpgSqlDAL<Dictionary_legacy>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Dictionary_legacy dictionary_legacy)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(dictionary_legacy);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Dictionary_legacy dictionary_legacy)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(dictionary_legacy);
            ConNpgSqlDAL<Dictionary_legacy>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Dictionary_legacy dictionary_legacy)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(dictionary_legacy);
            ConNpgSqlDAL<Dictionary_legacy>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            