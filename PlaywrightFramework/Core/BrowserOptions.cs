using System.Text.Json.Serialization;

namespace PlaywrightFramework.Core
{
    public class BrowserOptions
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = BrowserType.Chromium;
        [JsonPropertyName("headed")]
        public string Headed { get; set; } = "0";
    }
}
