using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using QueuePopDesktop.Models;
using QueuePopDesktop.Models.Responses;
using QueuePopDesktop.Properties;
using System.Globalization;
using System.Net.Http.Json;

namespace QueuePopDesktop
{
    internal class QueuePopService
    {
        static HttpClient client = new HttpClient();
        static string uri = Settings.Default.base_address;

        static QueuePopService()
        {
            client.BaseAddress = new Uri(uri);
        }

        public static async Task<bool> SendNotificationAsync(string guid, string gameTitle, string message)
        {
            try
            {
                string requestUri = QueryHelpers.AddQueryString("api/notification", new Dictionary<string, string>
                {
                    ["guid"] = guid,
                    ["game_title"] = gameTitle,
                    ["message"] = message,
                    ["desktop_version"] = Application.ProductVersion
                });

                HttpResponseMessage response = await client.PostAsync(requestUri, null);

                return response.IsSuccessStatusCode;

            }
            catch {
                return false;
            }
            
        }

        public static async Task<bool> ReportIssueAsync(Issue issue)
        {
            try {
                var content = new StringContent(JsonConvert.SerializeObject(issue), System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("api/issue", content);

                return response.IsSuccessStatusCode;
            }
            catch {
                return false;
            }

        }

        public static async Task<(ECheckForUpdateStatus status, float newVersion)> CheckForUpdate()
        {
            try
            {
                float version = float.Parse(Application.ProductVersion, CultureInfo.InvariantCulture.NumberFormat);
                HttpResponseMessage httpResponse = await client.GetAsync("api/version");
                var checkForUpdateResponse = await httpResponse.Content.ReadFromJsonAsync<CheckForUpdateResponse>();
                if (checkForUpdateResponse != null && httpResponse.IsSuccessStatusCode)
                {
                    if (checkForUpdateResponse.DesktopVersion > version)
                    {
                        return (ECheckForUpdateStatus.SHOULD_UPDATE, checkForUpdateResponse.DesktopVersion);
                    }
                    else
                    {
                        return (ECheckForUpdateStatus.UP_TO_DATE, checkForUpdateResponse.DesktopVersion);
                    }
                }
                else 
                {
                    return (ECheckForUpdateStatus.ERROR, -1);
                }
            }
            catch
            {
                return (ECheckForUpdateStatus.ERROR, -1);
            }
  
        }

        public enum ECheckForUpdateStatus { 
            UP_TO_DATE,
            SHOULD_UPDATE,
            ERROR
        }
    }
}
