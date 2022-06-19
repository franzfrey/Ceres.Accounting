namespace Ceres;

public class LogCommandHandlerDecorator<TServiceCommand> : IServiceCommandHandler<TServiceCommand>
where TServiceCommand : IServiceCommand
{
    private readonly IServiceCommandHandler<TServiceCommand> _decoratedCommand;

    public LogCommandHandlerDecorator(IServiceCommandHandler<TServiceCommand> decoratedCommand)
    {
        _decoratedCommand = decoratedCommand;
    }

    public void Execute(TServiceCommand command)
    {
        _decoratedCommand.Execute(command);
    }
}

