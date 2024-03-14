using System.Text.Json.Serialization;

namespace QueuePopDesktop.Models.Responses
{
    internal class CheckForUpdateResponse
    {
        [JsonPropertyName("desktop_version")]
        public float DesktopVersion { get; set; }

        [JsonPropertyName("android_version")]
        public float AndroidVersion { get; set; }
    }
}
