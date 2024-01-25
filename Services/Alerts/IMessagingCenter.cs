namespace TheWatch.Services;

public interface IMessagingCenter
{
    event EventHandler<object> MessageReceived;
    void Send<T>(T message);
    bool IsSubscribed<T>();
    Guid Subscribe<T>(Action<T> action);
    void Unsubscribe(Guid subscriptionId);
}