namespace TheWatch.Services;

public interface INavigationService
{
    Task NavigateToAsync<TPage>() where TPage : Page;
    Task GoBackAsync();
}