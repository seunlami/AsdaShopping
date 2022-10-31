using AsdaShopping.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AsdaShopping.StepDefinitions
{
    [Binding]
    public class AsdaLogInSteps
    {
        AsdaLogInPage asdaLogInPage;
        public AsdaLogInSteps()
        {
            asdaLogInPage = new AsdaLogInPage();

        }


        [Given(@"I navigate to website ""(.*)""")]
        public void GivenINavigateToWebsite(string url)
        {
            asdaLogInPage.NavigateToWebsite(url);
        }

        [Given(@"I click accept on the pop up screen")]
        public void GivenIClickAcceptOnThePopUpScreen()
        {
            asdaLogInPage.ClickAccept();
        }

        [Given(@"I click on register")]
        public void GivenIClickOnRegister()
        {
            asdaLogInPage.ClickRegister();
        }
        
        [Given(@"I enter email address ""(.*)""")]
        public void GivenIEnterEmailAddress(string email)
        {
            asdaLogInPage.EmailInsert(email);
        }
        
        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string password)
        {
            asdaLogInPage.EnterPassword(password);
        }
        
        [When(@"I click on register")]
        public void WhenIClickOnRegister()
        {
            asdaLogInPage.ClickOnRegister();
        }
        
        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Assert.That(asdaLogInPage.IsMyUserAccountDisplayed);
        }

        [Given(@"I click on Sign In")]
        public void GivenIClickOnSignIn()
        {
            asdaLogInPage.ClickOnSignIn();

        }

        [Given(@"I enter new email address ""(.*)""")]
        public void GivenIEnterNewEmailAddress(string email)
        {
            asdaLogInPage.EnterEmailAddress(email);
        }

        [Given(@"I enter new password ""(.*)""")]
        public void GivenIEnterNewPassword(string password)
        {
            asdaLogInPage.EnterTheNewPassword(password);
        }


        [When(@"I click on Sign in")]
        public void WhenIClickOnSignIn()
        {
            asdaLogInPage.ClickSignInButton();
        }

        //[Then(@"I should be logged into the website homepage")]
        //public void ThenIShouldBeLoggedIntoTheWebsiteHomepage()
        //{
        //    ScenarioContext.Current.Pending();
        //}

    }
}
