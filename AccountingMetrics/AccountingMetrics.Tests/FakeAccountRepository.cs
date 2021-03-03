using System;
using System.Collections.Generic;
using System.Text;
using AccountingMetrics;
namespace AccountingMetrics.Tests
{
    class FakeAccountRepository : IAccountRepository
    {
        // setup fake Account data to test the metrics
        private static IList<Account> accounts = new List<Account>
        {
            new Account{AccountCategory = "revenue", AccountType= "sales", ValueType = "credit", TotalValue = 1},
            new Account{AccountCategory = "revenue", AccountType= "sales", ValueType = "credit", TotalValue = 2},
            new Account{AccountCategory = "expense", AccountType = "overheads", ValueType = "debit", TotalValue = 3},
            new Account{AccountCategory = "expense", AccountType = "overheads", ValueType = "debit",TotalValue = 4},
            new Account{AccountCategory = "assets", AccountType = "current", ValueType = "debit",TotalValue = 2},
            new Account{AccountCategory = "assets", AccountType = "fixed", ValueType = "debit",TotalValue = 2},
            new Account{AccountCategory = "assets", AccountType = "bank", ValueType = "credit",TotalValue = 1},
            new Account{AccountCategory = "liability", AccountType = "current", ValueType = "debit",TotalValue = 1},
            new Account{AccountCategory = "liability", AccountType = "payroll", ValueType = "debit",TotalValue = 1},
            new Account{AccountCategory = "liability", AccountType = "current_accounts_payable", ValueType = "credit",TotalValue = 2},
        };
        public IList<Account> FindAllAccounts()
        {

            return accounts;

        }
    }
}
