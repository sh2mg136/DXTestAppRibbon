using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SqlRepository : IRepository
    {

        string _connectionString;
        public string ConnectionString
        {
            get { return _connectionString; }
        }


        internal SqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public bool Logon(string username, string password)
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(ConnectionString));
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Logon", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.Add("@Return", SqlDbType.Bit).Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    cmd.ExecuteScalar();
                    if (cmd.Parameters["@Return"] != null)
                    {
                        var val = cmd.Parameters["@Return"].Value;
                        result = Convert.ToBoolean(val);
                    }
                }
            }

            return result;
        }


        public QueryResult GetClients()
        {
            QueryResult result = new QueryResult();
            result.Data = new List<Account>();
            return result;
        }


        IEnumerable<Account> IRepository.GetAccounts()
        {
            IEnumerable<Account> accounts = new List<Account>();

            return accounts;
        }


        IEnumerable<Currency> IRepository.GetCurrencies()
        {
            IEnumerable<Currency> currencies = new List<Currency>();

            Debug.Assert(!string.IsNullOrWhiteSpace(ConnectionString));
            DataTable dt = new DataTable();

            string query = "select * from [Currency];";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            currencies = (from r in dt.AsEnumerable()
                          select new Currency()
                       {
                           Code = r.Field<int>("Id"),
                           Name = r.Field<string>("Name")
                       }).ToList();

            return currencies;
        }


    }


}
