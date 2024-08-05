using Microsoft.Playwright.NUnit;
using PlaywrightFramework.Core;

namespace PlaywrightFramework.Tests;

public abstract class TestBase : PageTest
{
    private static readonly PlaywrightConfiguration _playwrightConfig;

    static TestBase()
    {
        _playwrightConfig = new PlaywrightConfiguration();
    }

    [OneTimeSetUp]
    public void Setup()
    {
        Environment.SetEnvironmentVariable("Browser", _playwrightConfig.browserOptions?.Name);
        Environment.SetEnvironmentVariable("HEADED", _playwrightConfig.browserOptions?.Headed);
    }

    public override BrowserNewContextOptions ContextOptions()
    {
        return _playwrightConfig.browserNewContextOptions ?? new BrowserNewContextOptions();
    }

}