﻿using TheWatch.Models.Surveys;

namespace TheWatch.Services;

public interface ISurveyService
{
    Task<Survey> CreateSurvey(Survey survey);
    Task<bool> SubmitSurveyResponse(SurveyResponse response);
}