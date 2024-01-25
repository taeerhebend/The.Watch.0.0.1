namespace TheWatch.Models.Uploads;

public class AudioFile
{
    // The ID of the audio file
    public string Id { get; set; }

    // The name of the audio file
    public string Name { get; set; }

    // The file extension
    public string Extension { get; set; }

    // The size of the audio file in bytes
    public long Size { get; set; }

    // The audio file data
    public byte[] Data { get; set; }

    // The audio file creation date and time
    public DateTime CreationTime { get; set; }
}