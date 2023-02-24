using Microsoft.Playwright;
using PlaywrightFramework.Pages;
using System.Text.RegularExpressions;

namespace PlaywrightFramework.Tests;

[Parallelizable(ParallelScope.Self)]
public class Test : TestBase
{
    [Test]
    public async Task LogInTest()
    {
        LoginPage loginPage = new LoginPage(Page);
        await loginPage.GoTo();
        await loginPage.ClickLogin();
        await loginPage.Login("admin", "password");
        var isExist = await loginPage.IsEmployeeDetailsExists();
        Assert.IsTrue(isExist);
    }
}