using NLog;

namespace PlaywrightFramework.Pages
{
    //[TestFixture]
    public abstract class PageBase : IDisposable, IAsyncDisposable
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

        static PageBase()
        {
            LogManager.LoadConfiguration("nLog.config");
            logger = LogManager.GetCurrentClassLogger();
        }

        /*[SetUp]
        public void SetUp()
        {
            logger.Debug($"Test: '{TestContext.CurrentContext.Test.FullName}'");
        }
        */

        private void Page_Crash(object? sender, IPage e)
        {
            logger.Debug($"Crashed page URL is {e.Url}");
        }

        private void Page_PageError(object? sender, string e)
        {
            logger.Error(e);
        }

        private void Page_Console(object? sender, IConsoleMessage e)
        {
            logger.Debug(e.ToString());
        }

        private void Page_Close(object? sender, IPage e)
        {
            logger.Debug($"Closed page URL is {e.Url}");
        }

        private void Page_Load(object? sender, IPage e)
        {
            logger.Debug($"Loaded page URL is {e.Url}");
        }

        public void Dispose()
        {
            this.page.Load -= Page_Load;
            this.page.Close -= Page_Close;
            this.page.Console -= Page_Console;
            this.page.PageError -= Page_PageError;
            this.page.Crash -= Page_Crash;
            GC.SuppressFinalize(this);
        }

        public ValueTask DisposeAsync()
        {
            Dispose();
            return ValueTask.CompletedTask;
        }
    }
}
