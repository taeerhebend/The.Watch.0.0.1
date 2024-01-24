using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TheWatch.Services
{
    public class LocationService
    {
        private User _user;
        private Timer _timer;
        public LocationService(User user)
        {
            _user = user;
            _timer = new Timer(300000); // 5 minutes in milliseconds
            _timer.Elapsed += GetLocation;
            _timer.Start();
        }
        private async void GetLocation(object sender, ElapsedEventArgs e)
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            if (status != PermissionStatus.Granted)
            {
                status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }
            if (status == PermissionStatus.Granted)
            {
                try
                {
                    var location = await Geolocation.GetLastKnownLocationAsync();
                    if (location != null)
                    {
                        _user.Location = new Location { Latitude = location.Latitude, Longitude = location.Longitude };
                        _user.Timestamp = DateTime.Now;
                    }
                }
                catch (FeatureNotSupportedException fnsEx)
                {
                    // Handle not supported on device exception
                }
                catch (FeatureNotEnabledException fneEx)
                {
                    // Handle not enabled on device exception
                }
                catch (PermissionException pEx)
                {
                    // Handle permission exception
                }
                catch (Exception ex)
                {
                    // Unable to get location
                }
            }
        }
    }
}
