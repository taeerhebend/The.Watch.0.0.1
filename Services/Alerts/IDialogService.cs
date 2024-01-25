namespace TheWatch.Services.Alerts;

// Interface for Dialog Service: Provides functionality for showing alerts and notifications to the user.

public interface IDialogService
{
    Task ShowAlertAsync(string title, string message, string cancel = "OK");
}