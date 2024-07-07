using RabbitMQ.Client;

namespace AgendaTenis.Eventos.Servicos;

public interface IMessageBus
{
    public IConnection GetConnection();
    IModel GetChannel(IConnection connection);
}
