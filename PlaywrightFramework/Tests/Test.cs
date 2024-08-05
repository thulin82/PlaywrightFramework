using PlaywrightFramework.Pages;

namespace PlaywrightFramework.Tests;

[Parallelizable(ParallelScope.Self)]
public class Test : TestBase
{
    [Test]
    public async Task LogInTest()
    {
        LoginPage loginPage = new(Page);
        await loginPage.GoTo();
        await loginPage.ClickLogin();
        await loginPage.Login("admin", "password");
        var isExist = await loginPage.IsEmployeeDetailsExists();
        Assert.That(isExist, Is.True);
    }
}