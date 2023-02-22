namespace PlaywrightFramework.Pages
{
    public class PlaywrightPage : PageBase
    {
        private readonly ILocator _locator;

        public PlaywrightPage(IPage page) : base(page)
        {
            _locator = page.GetByRole(AriaRole.Link, new() { Name = "Get started" });
        }

        public async Task GoTo()
        {
            await page.GotoAsync("/");
        }

        public async Task ClickGetStarted()
        {
            await _locator.ClickAsync();
        }
    }
}
