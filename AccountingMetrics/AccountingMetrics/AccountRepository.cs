using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AccountingMetrics
{
    class AccountRepository : IAccountRepository
    {
        private readonly Data _jsonFile;
        public AccountRepository(string filePath)
        {
            Data jsonFile = JsonConvert.DeserializeObject<Data>(File.ReadAllText(filePath));
            _jsonFile = jsonFile;
        }
        public IList<Account> FindAllAccounts()
        {
            // Deseralize JSON file into the data object
            return _jsonFile.Accounts;
        }
    }
}
