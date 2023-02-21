namespace PlaywrightFramework.Pages
{
    public class SearchPage : PageBase
    {
        private readonly ILocator _locator;

        public SearchPage(IPage page) : base(page)
        {
            _locator = page.Locator("[placeholder='Search the web']");
        }

        public async Task GoTo()
        {
            await page.GotoAsync("/");
        }

        public async Task Search(string text)
        {
            await _locator.FillAsync(text);
            await _locator.PressAsync("Enter");
        }
    }
}
