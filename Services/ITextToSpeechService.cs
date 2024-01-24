namespace TheWatch.Services;


public interface ITextToSpeechService
{
    Task Speak(string text);
}