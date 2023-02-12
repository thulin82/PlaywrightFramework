using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
