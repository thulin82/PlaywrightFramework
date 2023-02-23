using System.Threading.Tasks;

namespace PlaywrightFramework.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }

        public async Task ClickLogin()
        {
            await lnkLogin.ClickAsync();
            await _page.WaitForURLAsync("**/Login", new() { Timeout = 2500 });
        }

        public async Task GoTo()
        {
            await _page.GotoAsync("/");
        }

        public async Task ClickEmployeeList()
        {
            await lnkEmployeeLists.ClickAsync();
        }

        public async Task Login(string userName, string password)
        {
            await txtUserName.FillAsync(userName);
            await txtPassword.FillAsync(password);
            await btnLogin.ClickAsync();
        }

        public async Task<bool> IsEmployeeDetailsExists()
        {
            return await lnkEmployeeDetails.IsVisibleAsync();
        }

        #region Locators
        private ILocator lnkLogin => _page.Locator("text=Login");
        private ILocator txtUserName => _page.Locator("#UserName");
        private ILocator txtPassword => _page.Locator("#Password");
        private ILocator btnLogin => _page.Locator("text=Log in");
        private ILocator lnkEmployeeDetails => _page.Locator("text='Employee Details'");
        private ILocator lnkEmployeeLists => _page.Locator("text='Employee List'");
        #endregion

    }
}
