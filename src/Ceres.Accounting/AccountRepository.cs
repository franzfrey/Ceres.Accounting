namespace Ceres.Accounting
{
    internal class AccountRepository
    {
        private readonly IAccountStore _store;

        public AccountRepository(IAccountStore store)
        {
            _store = store;
        }

        internal void Add(Account newAccount)
        {
            var accountState = newAccount.GetState();
            _store.Persist(accountState);
        }

        internal Account FindByName(string accountName)
        {
            var accountState = _store.FindByName(accountName);
            return Account.From(accountState);
        }
    }
}