using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWatch.Models.UserData.History;

namespace TheWatch.Services
{
    public interface IRewardService
    {
        IEnumerable<Reward> GetRewardsForUser(string email);
        bool ClaimReward(string email, string rewardId);
    }
}
