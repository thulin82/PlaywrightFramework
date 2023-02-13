using System.Text.Json.Serialization;

namespace PlaywrightFramework.Core
{
    public class Config
    {
        [JsonInclude]
        public BrowserOptions Browser { get; set; } = new BrowserOptions();
        [JsonInclude]
        public BrowserNewContextOptions BrowserContextOptions { get; set; } = new BrowserNewContextOptions();
    }
}
