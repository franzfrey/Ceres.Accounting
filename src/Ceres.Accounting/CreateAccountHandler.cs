namespace Ceres.Accounting;

internal class CreateAccountHandler : IServiceCommandHandler<CreateAccount>
{
    private readonly AccountRepository _accounts;

    public CreateAccountHandler(AccountRepository accounts)
    {
        _accounts = accounts;
    }

    public void Execute(CreateAccount command)
    {
        var newAccount = new Account(command.name, command.number, command.type, command.description);
        _accounts.Add(newAccount);
    }
}
