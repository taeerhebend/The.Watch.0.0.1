namespace TheWatch.Models.Uploads;

public class VideoUpload : MediaUpload
{
    public string Format { get; set; } // Format of the video file (MP4, AVI etc.)
    public TimeSpan Duration { get; set; } // Duration of the video
    public string Resolution { get; set; } // Resolution of the Video
}