using TheWatch.Models.Tutorials;

namespace TheWatch.Services.Learning;

public interface IQuizService
{
    Quiz GetQuizById(string quizId);
    bool SubmitQuizAnswers(string quizId, IDictionary<string, string> answers);
    QuizResult GetQuizResult(string quizId);
}