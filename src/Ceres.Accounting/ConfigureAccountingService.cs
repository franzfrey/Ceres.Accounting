using Microsoft.Extensions.DependencyInjection;

namespace Ceres.Accounting;

public static class ConfigureAccountingService {
    public static IServiceCollection AddAccountingService(this IServiceCollection services) {
        services.AddTransient<AccountingService>();
        services.AddTransient<AccountRepository>();
        services.AddTransient<IServiceCommandHandler<CreateAccount>, CreateAccountHandler>();
        return services;
    }
}