using Microsoft.Extensions.DependencyInjection;

namespace Ceres.Accounting;

public class AccountingService {
    private IServiceProvider _serviceProvider;

    public AccountingService(IServiceProvider serviceProvider) {
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
    }

    public void Execute<T>(T cmd) where T : IServiceCommand { 
        var handler = _serviceProvider.GetService<IServiceCommandHandler<T>>() ?? throw new Exception();
        handler.Execute(cmd);      
    }
}
