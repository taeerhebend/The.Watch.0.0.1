﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWatch.Models.Geodata;

namespace TheWatch.Models.Scheduling
{
    public class DesignatedResponder
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public bool IsAvailable { get; set; }

        public List<Calendar> Calendar { get; set; }

        public GeoPoint Location { get; set; }

        public GeoFence GeoFence { get; set; }

    }
}
