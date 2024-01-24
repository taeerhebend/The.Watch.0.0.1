using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatch.Models
{
    public class Settings
    {
        
        public User user { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        public bool ReceiveNotifications { get; set; }
        public bool ReceiveSMSForHelp { get; set; }
    
        public int Age { get; set; }
    
        public bool CanUploadImages { get; set; }
        public bool CanUploadPrerecordedVideo { get; set; }
        public bool CanTrackLocation { get; set; }
    
        public LocationTrackingInterval LocationTrackingInterval { get; set; } // A custom enum can be used for intervals I.E 5mins, 10mins, 15mins etc.
    
        public bool ReceiveEvacuationRequests { get; set; }
        public bool StartLiveVideoOnCheckIn { get; set; }

        public List<string> Pets { get; set; } // List of pet names or IDs
        public List<string> FamilyMembers { get; set; } // List of family member names or IDs
    }
}
