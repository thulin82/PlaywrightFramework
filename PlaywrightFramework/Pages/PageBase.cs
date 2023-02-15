using NUnit.Framework.Internal;

namespace PlaywrightFramework.Pages
{
    public abstract class PageBase
    {
        protected readonly IPage page;
        protected static readonly ILogger logger;

        public PageBase(IPage page)
        {
            this.page = page;
            this.page.Load += Page_Load;
            this.page.Close += Page_Close;
            this.page.Console += Page_Console;
            this.page.PageError += Page_PageError;
            this.page.Crash += Page_Crash;
        }

        private void Page_Crash(object? sender, IPage e)
        {
            throw new NotImplementedException();
        }

        private void Page_PageError(object? sender, string e)
        {
            throw new NotImplementedException();
        }

        private void Page_Console(object? sender, IConsoleMessage e)
        {
            throw new NotImplementedException();
        }

        private void Page_Close(object? sender, IPage e)
        {
            throw new NotImplementedException();
        }

        private void Page_Load(object? sender, IPage e)
        {
            throw new NotImplementedException();
        }
    }
}
