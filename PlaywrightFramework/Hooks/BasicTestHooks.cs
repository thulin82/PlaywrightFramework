using BoDi;
using PlaywrightFramework.PageObjects;
using PlaywrightFramework.Support;
using TechTalk.SpecFlow;

namespace PlaywrightFramework.Hooks;

[Binding]
public sealed class BasicTestHooks
{

    [BeforeScenario("BasicTest")]
    public async Task BeforeScenarioWithTag(IObjectContainer container)
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await BrowserSettings.InitializeBrowser(playwright, "Chromium");
        var pageObject = new LoginPageObject(browser);
        container.RegisterInstanceAs(playwright);
        container.RegisterInstanceAs(browser);
        container.RegisterInstanceAs(pageObject);
    }


    [AfterScenario("BasicTest")]
    public async Task AfterScenario(IObjectContainer container)
    {
        var browser = container.Resolve<IBrowser>();
        await browser.CloseAsync();
        var playwright = container.Resolve<IPlaywright>();
        playwright.Dispose();
    }
}