using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWatch.Models.Geodata;
using TheWatch.Models.UserData.Claims;
using TheWatch.Models.UserData.History;

namespace TheWatch.Models.UserData
{
    public class User
    {
        // Cosmos DB will auto-generate the Id if it is null during insertion
        [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "passwordHash")]
        public string PasswordHash { get; set; }



        public List<JwtToken> JwtTokens { get; set; } = new List<JwtToken>(); // List of JWTs issued to the user


        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? MobileNumber { get; set; }
        public Address? Address { get; set; }
        public DateTime? Birthday { get; set; }
        public int? Age { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsMobileVerified { get; set; }
        public bool? IsRegistered { get; set; }
        public bool? HasVehicle { get; set; }
        public bool? WillReceiveWatchSMS { get; set; }
        public bool? WillReceiveWatchNotifications { get; set; }
        public bool? WantsVoiceRecognition { get; set; }
        public bool? CanTrackLocation { get; set; }
        public TrackingFrequency TrackingFrequency { get; set; }

        public List<StoredPhrase>? Phrases { get; set; }

        public Child[]? Children { get; set; }
        public Pet[]? Pets { get; set; }

        [JsonProperty(PropertyName = "location")]
        public GeoPoint? Location { get; set; }



        public WatchHistory[]? WatchHistory { get; set; }
    }
}
