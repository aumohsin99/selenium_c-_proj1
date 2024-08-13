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

            //IWebDriver 

          




        }



        //static void Main() {


        public static void Main() { }
    
    }
}
