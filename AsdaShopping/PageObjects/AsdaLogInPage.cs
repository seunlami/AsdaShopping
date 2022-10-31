using AsdaShopping.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AsdaShopping.PageObjects
{
    class AsdaLogInPage
    {
        public AsdaLogInPage()
        {
            driver = Hooks1.driver;
        }

                       IWebDriver driver;


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        IWebElement Register => driver.FindElement(By.XPath("(//*[text()='Register'])[1]"));
        IWebElement Accept => driver.FindElement(By.XPath("//*[text()='I Accept']"));
        IWebElement EmailAdress => driver.FindElement(By.XPath("//*//input[@type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement RegisterButton => driver.FindElement(By.XPath("//*[text()='Register']"));
        IWebElement MyAccount => driver.FindElement(By.XPath("//*[text()='Your Account']"));
        IWebElement SignIn => driver.FindElement(By.XPath("(//*[text()='Sign in'])[1]"));
        IWebElement EnterEmail => driver.FindElement(By.XPath("(//*[@type='text'])[1]"));
        IWebElement EnterNewPassword => driver.FindElement(By.XPath("(//*[@type='password'])[1]"));
        IWebElement SignInButton => driver.FindElement(By.XPath("//*[@type='submit']"));












        public void ClickAccept()
        {
            Thread.Sleep(1000);
            Accept.Click();
        }


        public void ClickRegister()
        {
            Register.Click();
        }

        public void EmailInsert(string email)
        {
            EmailAdress.SendKeys(email);
;        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
         public void ClickOnRegister()
        {
            RegisterButton.Click();
        }

        public bool IsMyUserAccountDisplayed()
        {
            return MyAccount.Displayed;
        }

        public void ClickOnSignIn()
        {
            SignIn.Click();
        }
        public void EnterEmailAddress(string email)
        {
            EnterEmail.SendKeys(email);
        }

        public void EnterTheNewPassword(string ppassword)
        {
            EnterNewPassword.SendKeys(ppassword);
        }

        public void ClickSignInButton()
        {
            SignInButton.Click();
        }








































    }
}
