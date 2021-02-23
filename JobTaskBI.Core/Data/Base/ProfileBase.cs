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
    public class ProfileBase
    {
        #region Constructor
        public ProfileBase()
        {

        }
        #endregion

        #region Methods

        public IList<Profile> Get(Profile profile)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(profile);
            IList<Profile> response = ConNpgSqlDAL<Profile>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Profile> Get(Profile profile, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(profile, paged, total, page_quantity, page_number);
            IList<Profile> response = ConNpgSqlDAL<Profile>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Profile profile)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(profile);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

      

        public IList<Profile> GetCombo(Profile profile)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(profile);
            IList<Profile> response = ConNpgSqlDAL<Profile>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Profile profile)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(profile);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Profile profile)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(profile);
            ConNpgSqlDAL<Profile>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Profile profile)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(profile);
            ConNpgSqlDAL<Profile>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            