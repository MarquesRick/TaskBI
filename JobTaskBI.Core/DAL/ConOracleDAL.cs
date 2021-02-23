using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace Core.DAL
{
    public class ConOracleDAL<T> : BaseDAL<T> where T : new()
    {
        static ConOracleDAL<T> _instanceObj;

        public static ConOracleDAL<T> Instance
        {
            get
            {
                if (_instanceObj == null)
                    _instanceObj = new ConOracleDAL<T>();
                return _instanceObj;
            }
        }

        public override IDbConnection GetConnection()
        {
            string conn = GetConnectionStringOracle();
            OracleConnection connObj = new OracleConnection(conn);
            return connObj;
        }

        public IList<T> ExecuteSQL(string sql)
        {
            OracleCommand command;
            IList<T> retornoObj = null;

            var connObj = GetConnection();

            try
            {
                //if (connObj.State != ConnectionState.Open)
                connObj.Open();

                command = new OracleCommand(sql, (OracleConnection)connObj);

                var retornoBanco = command.ExecuteReader();

                var retornoBancoMapeado = MapaDAL<T>.MapReader(retornoBanco);

                retornoObj = retornoBancoMapeado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((connObj.State != ConnectionState.Broken) || (connObj.State != ConnectionState.Closed))
                    connObj.Close();
            }
            return retornoObj;
        }

        public DataSet ExecuteSQL2(string query)
        {
            DataSet ds = new DataSet();
            OdbcDataReader retornoBanco;
            OdbcConnection con = new OdbcConnection();
            con.ConnectionString = GetConnectionStringOracle();
            try
            {
                con.Open();
                OdbcDataAdapter da = new OdbcDataAdapter(query, con);
                da.Fill(ds);

                //foreach(Tables table in ds )
            }
            catch (Exception ex)
            {
                ds = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            //var retorno;
            //IList<ExempleTO> list = new IList<ExempleTO>();
            //return new IList<ExempleTO>();
            return ds;
        }
    }

}
