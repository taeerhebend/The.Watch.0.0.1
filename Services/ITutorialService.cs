namespace TheWatch.Services;

public interface ITutorialService
{
    IEnumerable<Tutorial> GetTutorials();
    Tutorial GetTutorialById(string tutorialId);
}