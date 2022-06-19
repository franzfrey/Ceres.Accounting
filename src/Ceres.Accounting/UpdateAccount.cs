namespace Ceres.Accounting;

public record UpdateAccount(string AccountName, string Description) : IServiceCommand;

internal class UpdateAccountHandler : IServiceCommandHandler<UpdateAccount>{
    private readonly AccountRepository _accounts;

    public UpdateAccountHandler(AccountRepository account)
    {
        _accounts = account ?? throw new ArgumentNullException(nameof(account));
    }

    public void Execute(UpdateAccount command)
    {
        var account = _accounts.FindByName(command.AccountName);
        account.Description = command.Description;
    }
}