namespace PlaywrightFramework.PageObjects;

public class LoginPageObject(IBrowser browser) : BasePageObject
{
    public override string PagePath => "http://www.eaapp.somee.com/Account/Login";
    public override IPage? Page { get; set; }
    public override IBrowser Browser { get; } = browser;

    public Task SetUserName(string userName) => Page?.FillAsync("#UserName", userName) ?? Task.CompletedTask;
    public Task SetPassword(string password) => Page?.FillAsync("#Password", password) ?? Task.CompletedTask;
    public Task ClickLoginButton() => Page?.ClickAsync("text=Log in") ?? Task.CompletedTask;
    public Task<bool> IsErrorMessageVisible() => Page?.IsVisibleAsync("text='Invalid login attempt.'") ?? Task.FromResult(false);
    public Task<bool> IsEmployeeDetailsVisible() => Page?.IsVisibleAsync("text='Employee Details'") ?? Task.FromResult(false);
}
