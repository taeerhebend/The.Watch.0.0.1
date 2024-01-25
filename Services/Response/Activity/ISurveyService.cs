using TheWatch.Models.Surveys;

namespace TheWatch.Services.Response.Activity;

public interface ISurveyService
{
    Task<Survey> CreateSurvey(Survey survey);
    Task<bool> SubmitSurveyResponse(SurveyResponse response);
}