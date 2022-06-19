namespace Ceres.Accounting
{
    public interface IAccountStore
    {
        void Persist(AccountState accountState);
        AccountState FindByName(string accountName);
    }
}