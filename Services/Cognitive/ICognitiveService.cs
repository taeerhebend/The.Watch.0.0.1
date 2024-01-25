// Interface for Cognitive Service: Offers features like speech-to-text, phrase detection, and sentiment analysis, leveraging Azure Cognitive Services.

using Microsoft.CognitiveServices.Speech.Audio;

namespace TheWatch.Services;
using Microsoft.CognitiveServices.Speech;
public interface ICognitiveService
{
    /// <summary>
    /// Transcribes audio to text using Azure Speech Service.
    /// </summary>
    /// <param name="audioStream">The audio stream to transcribe.</param>
    /// <returns>The transcribed text.</returns>
    Task<string> SpeechToTextAsync(PushAudioInputStream audioStream);
    
    /// <summary>
    /// Recognizes speech input for a list of given keywords.
    /// </summary>
    /// <param name="audioStream">The audio stream to transcribe.</param>
    /// <param name="phrases">List of phrases to detect in the speech input.</param>
    /// <returns>A boolean indicating whether any of the given phrases were spoken.</returns>
    Task<bool> DetectPhrasesAsync(PushAudioInputStream audioStream, IEnumerable<string> phrases);
    
    
    Task<ImageAnalysis> AnalyzeImageAsync(byte[] byteData);
    Task<string> GetTextFromSpeechAsync(byte[] byteData);
    Task<string> TranslateTextAsync(string text, string targetLanguage);
    Task<Sentiment> AnalyseSentimentAsync(string text);
    Task<KeyPhrases> ExtractKeyPhrasesAsync(string text);
    
}