using BoDi;
using NUnit.Framework.Interfaces;
using PlaywrightFramework.PageObjects;
using PlaywrightFramework.Support;
using TechTalk.SpecFlow;

namespace PlaywrightFramework.Hooks;

[Binding]
public sealed class DefaultHooks
{
    //This variable is used to save information of an element I interacted with, for example in one test step I added a product to a cart and later on I am able to assest the same information in a different step by accessing the values saved inside of the dynamic object/list.
    //public List<dynamic> dynamics;

    //private static dynamic? _config;
    //private static Utility? _utility;

    //private readonly ScenarioContext _scenarioContext;
    //public IPage Page;
    //public static IBrowser? Browser;
    //public static IBrowserContext? BrowserContext;
    //public static IPlaywright? PlaywrightContext;

    //[BeforeTestRun]
    //public static async Task BeforeTestRun(IObjectContainer container)
    //{
        //Reads the configuration from a JSON file.
        //_utility = new Utility();
        //_config = _utility.ReadFromJsonFile("../../../configuration.json");

        //In case ibs (Import browser state) is set to true, this will open a browser instance before performing all other tests, (perform an action such as login), the browser state (cookies) will be saved inside of the state.json file and imported to all other browser during the same test run allowing login skip.
        //if ((bool)_config.ibs)
        //{
        //    //PlaywrightContext = await Playwright.CreateAsync();
        //    var playwright = await Playwright.CreateAsync();

        //    //Browser = await InitializeBrowser((string)_config.browser, (bool)_config.btrheadless);
        //    var browser = await InitializeBrowser((string)_config.browser, (bool)_config.btrheadless);

        //    var browserContext = await browser.NewContextAsync(new BrowserNewContextOptions
        //    {
        //        ViewportSize = ViewportSize.NoViewport
        //    });

        //    var pageObject = new LoginPageObject(browser);

            //var page = await BrowserContext.NewPageAsync();

            //Perform the login here
            //await page.GotoAsync("https://www.saucedemo.com/");
            //await page.Locator("input[id='user-name']").FillAsync("standard_user");
            //await page.Locator("input[id='password']").FillAsync("secret_sauce");
            //await page.Locator("input[id='login-button']").ClickAsync();

            //this creates the browser state file
            //await BrowserContext.StorageStateAsync(new()
            //{
            //    Path = "../../../state.json"
            //});

            //await page.CloseAsync();

            //container.RegisterInstanceAs(playwright);
            //container.RegisterInstanceAs(browser);
            //container.RegisterInstanceAs(pageObject);
    //    }
    //}

    //[BeforeScenario]
    //public async Task BeforeScenario(IObjectContainer container)
    //{
    //    //At the start of each test the dynamic object is reinitialized and empty
    //    dynamics = new List<dynamic>();

    //    //PlaywrightContext = await Playwright.CreateAsync();
    //    var playwright = await Playwright.CreateAsync();

    //    //Browser = await InitializeBrowser((string)_config.browser, (bool)_config.headless);
    //    var browser = await InitializeBrowser((string)_config.browser, (bool)_config.headless);

    //    var browserContextOptions = new BrowserNewContextOptions
    //    {
    //        ViewportSize = ViewportSize.NoViewport,
    //    };

    //    //If isb is set to true, all tests inside feature files tagged with @SetState will import the state.json file (cookies) allowing login skip.
    //    if (_scenarioContext.ScenarioInfo.Tags.Any(tag => tag.Equals("SetState") && (bool)_config.ibs))
    //    {
    //        browserContextOptions.StorageStatePath = "../../../state.json";
    //    }

    //    var browserContext = await browser.NewContextAsync(new BrowserNewContextOptions
    //    {
    //        ViewportSize = ViewportSize.NoViewport
    //    });

    //    var pageObject = new LoginPageObject(browser);

    //    container.RegisterInstanceAs(playwright);
    //    container.RegisterInstanceAs(browser);
    //    container.RegisterInstanceAs(pageObject);
    //}

    //Performs browser initialization based on configuration file

}
