namespace PlaywrightFramework.Support;

public static class BrowserSettings
{
    public static async Task<IBrowser> InitializeBrowser(IPlaywright playwright, string browser, bool headless = true)
    {
        return browser switch
        {
            "Firefox" => await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = headless,
                //Timeout = 5000,
                SlowMo = 500
            }),
            "WebKit" => await playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = headless,
                //Timeout = 5000,
                SlowMo = 500
            }),
            _ => await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = headless,
                Args = ["--start-maximized"],
                //Timeout = 5000,
                //SlowMo = 500
            }),
        };
    }
}