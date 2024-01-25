namespace TheWatch.Models.Uploads;

public class ImageUpload : MediaUpload
{
    public string Format { get; set; } // Format of the image file (PNG, JPEG, etc.)
    public string Dimensions { get; set; } // Dimensions of the image
}