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
    public class MediatagsBase
    {
        #region Constructor
        public MediatagsBase()
        {

        }
        #endregion

        #region Methods

        public IList<Mediatags> Get(Mediatags mediatags)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(mediatags);
            IList<Mediatags> response = ConNpgSqlDAL<Mediatags>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Mediatags> Get(Mediatags mediatags, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(mediatags, paged, total, page_quantity, page_number);
            IList<Mediatags> response = ConNpgSqlDAL<Mediatags>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Mediatags mediatags)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(mediatags);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Mediatags> GetCombo(Mediatags mediatags)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(mediatags);
            IList<Mediatags> response = ConNpgSqlDAL<Mediatags>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Mediatags mediatags)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(mediatags);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Mediatags mediatags)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(mediatags);
            ConNpgSqlDAL<Mediatags>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Mediatags mediatags)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(mediatags);
            ConNpgSqlDAL<Mediatags>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            