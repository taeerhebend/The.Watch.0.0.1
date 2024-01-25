namespace TheWatch.Models.Uploads;

public class AudioUpload : MediaUpload
{
    public string Format { get; set; } // Format of the audio file (MP3, WAV etc.)
    public TimeSpan Duration { get; set; } // Duration of the audio
}