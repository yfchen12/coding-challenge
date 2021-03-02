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



        public float CalExpenses()
        {
            float expense = 0;
            foreach (var account in _accounts)
            {
                if (account.AccountCategory.Equals("expense"))
                {
                    expense += account.TotalValue;
                }
            }
            return expense;
        }

        public float CalGrossProfitMargin(float revenue)
        {
            float totalSalesInDebit = 0;
            float grossMargin;
            foreach(var account in _accounts)
            {
                if (account.AccountType.Equals("sales") && account.ValueType.Equals("debit"))
                {
                    totalSalesInDebit += account.TotalValue;
                }
            }

            grossMargin = totalSalesInDebit / revenue;
            return grossMargin;
        }

        public float CalNetProfitMargin(float revenue, float expenses)
        {
            float netMargin = (revenue - expenses) / revenue;

            return netMargin;
        }
    }
}
