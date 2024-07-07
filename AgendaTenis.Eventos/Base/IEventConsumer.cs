namespace AgendaTenis.Eventos.Base;

public interface IEventConsumer
{
    Task Consume(CancellationToken stoppingToken);
}
