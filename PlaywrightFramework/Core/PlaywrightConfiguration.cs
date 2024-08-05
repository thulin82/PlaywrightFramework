using PlaywrightFramework.Utils;

namespace PlaywrightFramework.Core;

public class PlaywrightConfiguration
{
    public readonly BrowserOptions? browserOptions;
    public readonly BrowserNewContextOptions? browserNewContextOptions;

    public PlaywrightConfiguration()
    {
        var config = JsonReader.Read<Config>("configuration.json");
        if (config != null)
        {
            browserOptions = config.Browser;
            browserNewContextOptions = config.BrowserContextOptions;
        }

    }
}
