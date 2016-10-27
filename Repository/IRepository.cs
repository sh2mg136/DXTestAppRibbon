using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    interface IRepository
    {
        bool Logon(string username, string password);
        
        QueryResult GetClients();

        IEnumerable<Account> GetAccounts();

        IEnumerable<Currency> GetCurrencies();
    }



    public class ErrorDetails
    {
        public int code { get; set; }
        public string Description { get; set; }
    }

    public class QueryResult
    {
        public bool HasErrors { get; set; }
        public IEnumerable<object> Data { get; set; }
        public IList<ErrorDetails> Errors { get; set; }

        public QueryResult()
        {
            HasErrors = false;
            Errors = new List<ErrorDetails>();
        }
    }

    public class Account
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

    public class Currency
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }

}
