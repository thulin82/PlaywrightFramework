using FluentAssertions;
using PlaywrightFramework.PageObjects;
using TechTalk.SpecFlow;

namespace PlaywrightFramework.Steps;

[Binding]
public class BasicTestSteps(LoginPageObject loginPageObject)
{
    private readonly LoginPageObject _pageObject = loginPageObject;

    [Given(@"the user is on the homepage")]
    public async Task GivenTheUserIsOnTheHomepage()
    {
        await _pageObject.NavigateAsync();
    }

    [When(@"the user is logging in with correct credentials")]
    public async Task WhenTheUserIsLoggingInWithCorrectCredentials()
    {
        await _pageObject.SetUserName("admin");
        await _pageObject.SetPassword("password");
        await _pageObject.ClickLoginButton();
    }

    [Then(@"the user is forwarded to the correct page")]
    public async Task ThenTheUserIsForwardedToTheCorrectPage()
    {
        await _pageObject.IsEmployeeDetailsVisible();
    }

    [When(@"the user is logging in with invalid credentials")]
    public async Task WhenTheUserIsLoggingInWithInvalidCredentials()
    {
        await _pageObject.SetUserName("admin");
        await _pageObject.SetPassword("admin");
        await _pageObject.ClickLoginButton();
    }

    [Then(@"the user is faced with and error message")]
    public async Task ThenTheUserIsFacedWithAndErrorMessage()
    {
        await _pageObject.IsErrorMessageVisible();
    }

    [Then(@"the user remains on the login page")]
    public void ThenTheUserRemainsOnTheLoginPage()
    {
        _pageObject.Page?.Url.Should().EndWith("/Account/Login");
    }
}
