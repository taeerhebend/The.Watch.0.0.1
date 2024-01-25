using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatch.Services
{
    public interface INotificationService
    {
        Task SendEmailAsync(string toEmail, string subject, string message);
        Task SendPushNotificationAsync(string userId, string title, string message);
        Task SendSMSAsync(string phoneNumber, string message);
        Task<bool> SubscribeUserAsync(string userId, string topic);
        Task<bool> UnsubscribeUserAsync(string userId, string topic);
    }
}
