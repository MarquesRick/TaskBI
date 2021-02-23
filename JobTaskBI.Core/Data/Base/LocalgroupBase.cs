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
    public class LocalgroupBase
    {
        #region Constructor
        public LocalgroupBase()
        {

        }
        #endregion

        #region Methods

        public IList<Localgroup> Get(Localgroup localgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localgroup);
            IList<Localgroup> response = ConNpgSqlDAL<Localgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Localgroup> Get(Localgroup localgroup, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localgroup, paged, total, page_quantity, page_number);
            IList<Localgroup> response = ConNpgSqlDAL<Localgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Localgroup localgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(localgroup);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Localgroup> GetCombo(Localgroup localgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(localgroup);
            IList<Localgroup> response = ConNpgSqlDAL<Localgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Localgroup localgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(localgroup);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Localgroup localgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(localgroup);
            ConNpgSqlDAL<Localgroup>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Localgroup localgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(localgroup);
            ConNpgSqlDAL<Localgroup>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            