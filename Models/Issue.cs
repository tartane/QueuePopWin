using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePopDesktop.Models
{
    internal class Issue
    {

        [JsonProperty("guid")]
        public Guid Guid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("desktop_version")]
        public float DesktopVersion { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
