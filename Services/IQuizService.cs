namespace TheWatch.Services;

public interface IQuizService
{
    Quiz GetQuizById(string quizId);
    bool SubmitQuizAnswers(string quizId, IDictionary<string, string> answers);
    QuizResult GetQuizResult(string quizId);
}