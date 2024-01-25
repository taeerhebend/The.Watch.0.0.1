namespace TheWatch.Models.Uploads
{
    public class GuidanceRequest
    {
        public int RequestId { get; set; } // Unique identifier for the guidance request
        public string RequesterName { get; set; } // Name of the person or entity making the request
        public DateTime RequestDate { get; set; } // Date when the request was made
        public string GuidanceTopic { get; set; } // Topic for which guidance is requested
        public string Status { get; set; } // Status of the request (e.g., pending, approved, rejected)
    }
}