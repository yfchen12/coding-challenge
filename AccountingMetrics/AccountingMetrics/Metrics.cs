using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingMetrics
{
    class Metrics
    {
        private readonly IList<Account> _accounts;

        // retrive the account data when instantiating the Metrics object
        public Metrics(IAccountRepository IAccountRepository)
        {
            _accounts = IAccountRepository.FindAllAccounts();
        }

        public float CalRevenue()
        {
            float revenue = 0;
            foreach(var account in _accounts)
            {
                if (account.AccountCategory.Equals("revenue"))
                {
                    revenue += account.TotalValue;
                }
            }
            return revenue;
        }


    }
}
