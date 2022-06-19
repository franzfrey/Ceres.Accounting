namespace Ceres;

public interface IServiceCommandHandler<TServiceCommand> where TServiceCommand : IServiceCommand {
    void Execute(TServiceCommand command);
}

