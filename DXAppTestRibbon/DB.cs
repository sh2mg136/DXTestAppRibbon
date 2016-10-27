using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXAppTestRibbon
{
    internal class DB
    {
        string _connectionString;
        public string ConnectionString
        {
            get { return _connectionString; }
        }


        internal DB( string connectionString )
        {
            _connectionString = connectionString;
        }


        internal bool Logon( string username, string password )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            bool result = false;
            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "Logon", connection ))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue( "@UserName", username );
                    cmd.Parameters.AddWithValue( "@Password", password );
                    cmd.Parameters.Add( "@Return", SqlDbType.Bit ).Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    cmd.ExecuteScalar();
                    if (cmd.Parameters["@Return"] != null)
                    {
                        var val = cmd.Parameters["@Return"].Value;
                        result = Convert.ToBoolean( val );
                    }
                }
            }

            return result;
        }


        internal DataTable GetCurrencies()
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            DataTable dt = new DataTable();

            string query = "select * from [Currency];";

            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( query, connection ))
                {
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load( reader );
                    }
                }
            }

            return dt;
        }


        internal void AddCurrency( string code )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "AddCurrency", connection ))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue( "@Code", code );
                    connection.Open();
                    cmd.ExecuteScalar();
                }
            }
        }


        internal void AddSubject( string code )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "AddSubject", connection ))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue( "@Name", code );
                    connection.Open();
                    cmd.ExecuteScalar();
                }
            }
        }


        internal int AddAccount( int subjectId, string accountName, int currencyId )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            int result = 0;
            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "AddAccount", connection ))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue( "@SubjectId", subjectId );
                    cmd.Parameters.AddWithValue( "@AccountName", accountName );
                    cmd.Parameters.AddWithValue( "@CurrencyId", currencyId );
                    cmd.Parameters.Add( "@AccountId", SqlDbType.Int ).Direction = ParameterDirection.Output;
                    connection.Open();
                    cmd.ExecuteScalar();
                    if (cmd.Parameters["@AccountId"] == null
                        || cmd.Parameters["@AccountId"].Value == DBNull.Value)
                        throw new InvalidOperationException( "Счёт не создан" );
                    else
                        result = Convert.ToInt32( cmd.Parameters["@AccountId"].Value );
                }
            }
            return result;
        }

        internal void DeleteCurrency( int id )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "DeleteCurrency", connection ))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue( "@Id", id );
                    connection.Open();
                    cmd.ExecuteScalar();
                }
            }
        }


        internal void DeleteSubject( int id )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "delete from [Subjects] where Id=@Id;", connection ))
                {
                    cmd.Parameters.AddWithValue( "@Id", id );
                    connection.Open();
                    cmd.ExecuteScalar();
                }
            }
        }


        internal void DeleteAccount( int accountId )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "delete from [Accounts] where Id=@Id;", connection ))
                {
                    cmd.Parameters.AddWithValue( "@Id", accountId );
                    connection.Open();
                    cmd.ExecuteScalar();
                }
            }
        }

        internal DataTable GetSubjects()
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( ConnectionString ) );
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection( ConnectionString ))
            {
                using (SqlCommand cmd = new SqlCommand( "GetSubjects", connection ))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load( reader );
                    }
                }
            }

            return dt;
        }

    }

}
