using Microsoft.Playwright;
using PlaywrightFramework.Pages;
using System.Text.RegularExpressions;

namespace PlaywrightFramework.Tests;

[Parallelizable(ParallelScope.Self)]
public class Test : TestBase
{
    [Test]
    public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
    {
        PlaywrightPage page = new PlaywrightPage(Page);
        await page.GoTo();
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
        await page.ClickGetStarted();
        await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        await Expect(Page).ToHaveTitleAsync(new Regex(".*Installation"));
    }

    [Test]
    public async Task TestingwithPOM()
    {
        LoginPage loginPage = new LoginPage(Page);
        await loginPage.GoTo();
        await loginPage.ClickLogin();
        await loginPage.Login("admin", "password");
        var isExist = await loginPage.IsEmployeeDetailsExists();
        Assert.IsTrue(isExist);
    }
}