using System.Collections.Generic;

namespace Ceres.Accounting.Specs
{
    internal class InMemoryAccountStore : IAccountStore
    {
        private readonly Dictionary<string, AccountState> accounts = new Dictionary<string, AccountState>();

        public void Persist(AccountState accountState)
        {
            accounts.Add(accountState.Name, accountState);
        }
    }
};