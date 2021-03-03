using System.Collections.Generic;

namespace AccountingMetrics
{
    public interface IAccountRepository
    {
        public IList<Account> FindAllAccounts();
    }
}