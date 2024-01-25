namespace TheWatch.Models.Uploads;

public class MediaUpload
{
    public int Id { get; set; }  //Unique Identifier
    public string FileName { get; set; }  //The original filename
    public string MediaUrl { get; set; }  // URL of the media file in Blob Storage
    public string MediaType { get; set; } // Type of the media (Image, Video, Audio)
    public DateTime UploadDate { get; set; } // The date when the file was uploaded
    
        
}