namespace TheWatch.Services;

public interface IPaginationService
{
    int TotalPages { get; }
    int CurrentPage { get; }
    bool HasMoreItems { get; }
    Task LoadNextPageAsync();
}

