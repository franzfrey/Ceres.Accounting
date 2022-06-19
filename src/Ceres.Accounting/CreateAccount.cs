namespace Ceres.Accounting;

public record CreateAccount(string name, string number, string type, string? description = null) : IServiceCommand;

