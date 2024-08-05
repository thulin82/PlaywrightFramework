namespace PlaywrightFramework.Pages;

public class LoginPage(IPage page) : PageBase(page)
{
    private readonly IPage _page = page;

    public async Task ClickLogin()
    {
        await LnkLogin.ClickAsync();
        await _page.WaitForURLAsync("**/Login", new() { Timeout = 2500 });
    }

    public async Task GoTo()
    {
        await _page.GotoAsync("/");
    }

    public async Task ClickEmployeeList()
    {
        await LnkEmployeeLists.ClickAsync();
    }

    public async Task Login(string userName, string password)
    {
        await TxtUserName.FillAsync(userName);
        await TxtPassword.FillAsync(password);
        await BtnLogin.ClickAsync();
    }

    public async Task<bool> IsEmployeeDetailsExists()
    {
        return await LnkEmployeeDetails.IsVisibleAsync();
    }

    #region Locators
    private ILocator LnkLogin => _page.Locator("text=Login");
    private ILocator TxtUserName => _page.Locator("#UserName");
    private ILocator TxtPassword => _page.Locator("#Password");
    private ILocator BtnLogin => _page.Locator("text=Log in");
    private ILocator LnkEmployeeDetails => _page.Locator("text='Employee Details'");
    private ILocator LnkEmployeeLists => _page.Locator("text='Employee List'");
    #endregion
}
