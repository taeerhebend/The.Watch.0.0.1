using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatch.Models
{
    public class Reward
    {
        public string TransactionId { get; set; }
        public List<string> HelperUserIds { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public Reward(string transactionId, List<string> helperUserIds, string description)
        {
            TransactionId = transactionId;
            HelperUserIds = helperUserIds;
            Date = DateTime.UtcNow;
            Description = description;
        }
    }
}