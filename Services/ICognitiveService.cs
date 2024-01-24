namespace TheWatch.Services;

public class ICognitiveService
{
    Task<ImageAnalysis> AnalyzeImageAsync(byte[] byteData);
    Task<string> GetTextFromSpeechAsync(byte[] byteData);
    Task<string> TranslateTextAsync(string text, string targetLanguage);
    Task<Sentiment> AnalyseSentimentAsync(string text);
    Task<KeyPhrases> ExtractKeyPhrasesAsync(string text);
    
}