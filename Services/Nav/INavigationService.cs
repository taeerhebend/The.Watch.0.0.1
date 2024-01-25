namespace TheWatch.Services.Nav;

public interface INavigationService
{
    Task NavigateToAsync<TPage>() where TPage : Page;
    Task GoBackAsync();
}