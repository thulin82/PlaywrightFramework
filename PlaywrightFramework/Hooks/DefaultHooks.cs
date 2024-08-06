using BoDi;
using TechTalk.SpecFlow;

namespace PlaywrightFramework.Hooks;

[Binding]
public sealed class DefaultHooks
{

    [BeforeTestRun]
    public static async Task BeforeTestRun(IObjectContainer container)
    {

    }

    [AfterTestRun]
    public static async Task AfterTestRun(IObjectContainer container)
    {

    }
}
