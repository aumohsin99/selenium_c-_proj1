using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTest
{
    class Tests
    {

        
        [SetUp]
        public void Setup()
        {
            // include nagivate, maximize function here
            // for navigation, pass URL as a param

        }

        [Test]
        static public void TestforGoogleHomepage()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();

            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Return);
            
            //driver.wa
            driver.Close();
        }

        [Test]
        public void LoginTestforBStackDemo()
        {

            //TODO get username of BO as a parm from the caller function to be used here

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://bstackdemo.com/");
            driver.Manage().Window.Maximize();
            

            IWebElement SiginInButton = driver.FindElement(By.Id("signin"));
            SiginInButton.Click();


            string currentURL = driver.Url;
            string expectedURL = "https://bstackdemo.com/signin";

            // have to add asertion here for correct URL of page
            //Assert assert =

            //Assert.assertEquals(expectedURL, currentURL);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait until the element is present
            IWebElement loginScreenWait = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]")));
            
            IWebElement usernameplaceholder = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]"));
            usernameplaceholder.Click();

            IWebElement usernameoption = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'demouser')]")));
            usernameoption.Click();

            IWebElement passwordplaceholder = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[2]/div[1]/div[1]"));
            passwordplaceholder.Click();
           
            IWebElement passowrordoption = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'testingisfun99')]")));
            passowrordoption.Click();


            IWebElement LoginButton = driver.FindElement(By.Id("login-btn"));
            LoginButton.Click();
            
            // assert URL here to be signin=true

        }


        [Test]
        public void LogoutfromDashbaord()
        {
            //TODO get username of BO as a parm from the caller function to be used here

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://bstackdemo.com/");
            driver.Manage().Window.Maximize();


            IWebElement SiginInButton = driver.FindElement(By.Id("signin"));
            SiginInButton.Click();

            string currentURL = driver.Url;
            string expectedURL = "https://bstackdemo.com/signin";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait until the element is present
            IWebElement loginScreenWait = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]")));
            IWebElement usernameplaceholder = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]"));
            usernameplaceholder.Click();

            IWebElement usernameoption = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'demouser')]")));
            usernameoption.Click();

            IWebElement passwordplaceholder = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[2]/div[1]/div[1]"));
            passwordplaceholder.Click();

            IWebElement passowrordoption = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'testingisfun99')]")));
            passowrordoption.Click();


            IWebElement LoginButton = driver.FindElement(By.Id("login-btn"));
            LoginButton.Click();

            // assert URL here to be signin=true


            //IWebDriver webDriver = new ChromeDriver();

            //TODO Confirm if the right user is logged in and name of user is being shown at the top left corner underlined
            /* IWebElement usernameOfLoggedInUser = webDriver.FindElement(By.CssSelector("username"));
             string name = usernameOfLoggedInUser.GetAttribute(usernameOfLoggedInUser.Text);
             System.Console.WriteLine(name);*/
            IWebElement logoutButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("logout")));
            logoutButton.Click();

            IWebElement signinButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("signin")));
        }

        [Test]
        public void IncorrectCredentialsLoginAttempt()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://bstackdemo.com/");
            driver.Manage().Window.Maximize();


            IWebElement SiginInButton = driver.FindElement(By.Id("signin"));
            SiginInButton.Click();

            string currentURL = driver.Url;
            string expectedURL = "https://bstackdemo.com/signin";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait until the element is present
            // TODO change xpath to something better
            IWebElement loginScreenWait = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]")));
            IWebElement usernameplaceholder = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[1]/div[1]/div[1]"));
            usernameplaceholder.Click();

            IWebElement usernameoption = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'demouser')]")));
            usernameoption.Click();

            IWebElement passwordplaceholder = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/form[1]/div[2]/div[2]/div[1]/div[1]"));
            passwordplaceholder.Click();

            IWebElement passowrordoption = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(text(),'testingisfun99')]")));
            passowrordoption.Click();

            //IWebElement passowrordoption1 = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//div[contains(@class,'css-1pahdxg-control')]//div[contains(@class,'css-1hwfws3')]")));
            //passowrordoption1.Click();


            //passowrordoption1.SendKeys("ksfjklfjaklf");


            //ebElement LoginButton = driver.FindElement(By.Id("login-btn"));
           //loginButton.Click();



        }
        //static void Main() {


        public static void Main() { }
    
    }
}
