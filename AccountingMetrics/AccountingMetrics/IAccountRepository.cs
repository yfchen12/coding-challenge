using System.Collections.Generic;

namespace AccountingMetrics
{
    internal interface IAccountRepository
    {
        public IList<Account> FindAllAccounts();
    }
}