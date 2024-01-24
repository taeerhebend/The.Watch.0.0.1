using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWatch.Models.UserData.History;

namespace TheWatch.Services
{
    public interface IEventRecordingService
    {
        Task<Recording> StartEventRecording(string email);
        Task StopEventRecording(string recordingId);
    }

    public class EventRecordingService : IEventRecordingService
    {
    }
}
