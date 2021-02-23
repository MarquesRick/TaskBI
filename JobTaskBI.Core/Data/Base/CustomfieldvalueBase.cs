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
    public class CustomfieldvalueBase
    {
        #region Constructor
        public CustomfieldvalueBase()
        {

        }
        #endregion

        #region Methods

        public IList<Customfieldvalue> Get(Customfieldvalue customfieldvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customfieldvalue);
            IList<Customfieldvalue> response = ConNpgSqlDAL<Customfieldvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Customfieldvalue> Get(Customfieldvalue customfieldvalue, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customfieldvalue, paged, total, page_quantity, page_number);
            IList<Customfieldvalue> response = ConNpgSqlDAL<Customfieldvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Customfieldvalue customfieldvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(customfieldvalue);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Customfieldvalue> GetCombo(Customfieldvalue customfieldvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(customfieldvalue);
            IList<Customfieldvalue> response = ConNpgSqlDAL<Customfieldvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Customfieldvalue customfieldvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(customfieldvalue);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Customfieldvalue customfieldvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(customfieldvalue);
            ConNpgSqlDAL<Customfieldvalue>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Customfieldvalue customfieldvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(customfieldvalue);
            ConNpgSqlDAL<Customfieldvalue>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            