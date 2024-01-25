// Interface for Messaging Center: Manages sending and receiving messages across different components of the application, enhancing decoupled communication.

namespace TheWatch.Services.Alerts;

public interface IMessagingCenter
{
    event EventHandler<object> MessageReceived;
    void Send<T>(T message);
    bool IsSubscribed<T>();
    Guid Subscribe<T>(Action<T> action);
    void Unsubscribe(Guid subscriptionId);
}