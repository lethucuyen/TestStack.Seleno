using OpenQA.Selenium;
using TestStack.Seleno.PageObjects;

namespace TestStack.Seleno.Samples.MvcMusicStore.FunctionalTests.Step4.Pages
{
    public class NavigationComponent : UiComponent
    {
        public LogonPage GoToAdminForAnonymousUser()
        {
            return NavigateTo<LogonPage>(By.LinkText("Admin"));
        }
    }
}