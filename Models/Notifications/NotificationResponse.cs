namespace TheWatch.Models.Notifications;

public class NotificationResponse
{
    // Unique identifier for each notification
    public Guid NotificationId { get; set; }

    // This property can be used to determine the type or category of the notification
    public string NotificationType { get; set; }

    // The message/title of the notification
    public string Title { get; set; }

    // Detailed content/ body of the notification
    public string Content { get; set; }

    // The date and time at which the notification was sent
    public DateTime NotificationSentTime { get; set; }

    // This property might contain additional data sent with the notification
    public string DataPayload { get; set; }

    // The date and time at which the user responded to the notification
    public DateTime ResponseTime { get; set; }

    // The action taken by the user in response to the notification
    public string UserAction { get; set; }

    // Any additional feedback or comments provided by the user
    public string UserFeedback { get; set; }
}