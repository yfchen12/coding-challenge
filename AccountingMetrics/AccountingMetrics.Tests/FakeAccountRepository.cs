using System;
using System.Collections.Generic;
using System.Text;
using AccountingMetrics;
namespace AccountingMetrics.Tests
{
    class FakeAccountRepository : IAccountRepository
    {
        private static IList<Account> accounts = new List<Account>
        {
            new Account{AccountCategory = "revenue", AccountType= "sales", ValueType = "credit", TotalValue = 1},
            new Account{AccountCategory = "revenue", AccountType= "sales", ValueType = "credit", TotalValue = 2},
            new Account{AccountCategory = "expenses", AccountType = "overheads", ValueType = "debit", TotalValue = 3},
            new Account{AccountCategory = "expenses", AccountType = "overheads", ValueType = "debit",TotalValue = 4},

        };
        public IList<Account> FindAllAccounts()
        {

            return accounts;

        }
    }
}
