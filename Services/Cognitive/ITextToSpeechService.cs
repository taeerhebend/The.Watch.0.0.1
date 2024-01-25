// Interface for Text to Speech Service: Converts text into spoken words, potentially useful for accessibility features.

namespace TheWatch.Services.Cognitive;


public interface ITextToSpeechService
{
    Task Speak(string text);
}