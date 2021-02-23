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
    public class DeviceBase
    {
        #region Constructor
        public DeviceBase()
        {

        }
        #endregion

        #region Methods

        public IList<Device> Get(Device device)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(device);
            IList<Device> response = ConNpgSqlDAL<Device>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Device> Get(Device device, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(device, paged, total, page_quantity, page_number);
            IList<Device> response = ConNpgSqlDAL<Device>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Device device)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(device);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Device> GetCombo(Device device)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(device);
            IList<Device> response = ConNpgSqlDAL<Device>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Device device)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(device);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Device device)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(device);
            ConNpgSqlDAL<Device>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Device device)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(device);
            ConNpgSqlDAL<Device>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            