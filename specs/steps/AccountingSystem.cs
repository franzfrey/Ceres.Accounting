using System;

using Microsoft.Extensions.DependencyInjection;

namespace Ceres.Accounting.Specs
{
    internal class AccountingSystem
    {
        private readonly IServiceProvider _serviceProvider;

        public AccountingSystem()
        {
            _serviceProvider = new ServiceCollection()
                .AddAccountingService()
                .AddSingleton<IAccountStore, InMemoryAccountStore>()
                .BuildServiceProvider();
        }

        public void Send<T>(T cmd) where T : IServiceCommand {
            _serviceProvider.GetService<AccountingService>().Execute(cmd);
        }
    }
}