namespace TheWatch.Models.Uploads
{
    public class ImageFile
    {
        public string Id { get; set; }
        public byte[] Data { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
        public bool IsTakenFromCamera { get; set; }
    }
}