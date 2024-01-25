using TheWatch.Models.Tutorials;

namespace TheWatch.Services.Learning;

public interface ITutorialService
{
    IEnumerable<Tutorial> GetTutorials();
    Tutorial GetTutorialById(string tutorialId);
}