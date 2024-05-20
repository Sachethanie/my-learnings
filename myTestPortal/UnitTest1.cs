using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace myTestPortal
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // 1. Creare a new instance of Selenium Web Driver

            IWebDriver driver = new ChromeDriver();

            //used method : "NEW CROMDRIVE" to automate the google chrome Browser. this method initialize the Web driver for chrome

            // 2. Navigate to the URL

            driver.Navigate().GoToUrl("https://www.google.com/");

            //  used methods : "NAVIGATE"to navigate to specific URL or to navigate through browser history
            //                 "GOTOURL(Sring URL)" to loads a new web page in the current browsre window with the specified URL

            // 2a. Maximize the browser window

            driver.Manage().Window.Maximize();
            //used methods : "Manage" to provide methods to manage the Browser 
            //               "Window" to controling the size and position of the browsre window
            //              "Maximize" to maximize the Browser window


            //  3. Find the element

            IWebElement webElement = driver.FindElement(By.Name("q"));
            //IWebElement webElement = driver.FindElement(By.Id("input"));

            //Used methods : "FindElement(By)" to find element usinf By.Name, ID, Xpath etc.
            //Locators can be use are; By.Id, By.Name, By.TagName, By.ClassName,By.Xpath 

            // 4., Type in the element

            webElement.SendKeys("Selenium");
            //method used : "SendKeys" to Send specified characters to the element

            //5. Click on the element

            //webElement.SendKeys(Keys.Enter);  (by using Enter key also able to go inside to the URL)  

            webElement.SendKeys(Keys.Return);
            //used methods : "SendKeys(Keys.)" to select the key that need to peform





        }



        [Test]
        public void EAWebSiteTest()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            IWebElement loginLink = driver.FindElement(By.LinkText("Login"));
            loginLink.Click();

            IWebElement UserName = driver.FindElement(By.Name("UserName"));
            UserName.SendKeys("admin");

            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("password");

            IWebElement RememberMeButton = driver.FindElement(By.Name("RememberMe"));
            RememberMeButton.Click();

            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input"));
            LoginButton.Click();


        }

        /* [Test]
         public void EAWebSiteTestReduceSizeCode()

         {
             IWebDriver driver = new ChromeDriver();
             driver.Navigate().GoToUrl("http://eaapp.somee.com/");

             driver.FindElement(By.LinkText("Login")).Click();

             driver.FindElement(By.Name("UserName")).SendKeys("admin");

             driver.FindElement(By.Name("Password")).SendKeys("password");

             driver.FindElement(By.Name("RememberMe")).Click();

             driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input")).Click();



         }*/

        [Test]
        public void WorkingWithAdvancedControls()

        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            IWebElement loginLink = driver.FindElement(By.LinkText("Login"));
            loginLink.Click();

            IWebElement UserName = driver.FindElement(By.Name("UserName"));
            UserName.SendKeys("admin");

            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("password");

            IWebElement RememberMeButton = driver.FindElement(By.Name("RememberMe"));
            RememberMeButton.Click();

            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[4]/div/input"));
            LoginButton.Click();


            //select item from dropdown menu

            IWebElement EmployeeList = driver.FindElement(by: By.XPath("/html/body/div[1]/div/div[2]/ul/li[3]/a"));
            EmployeeList.Click();

            IWebElement CreateNewEmployee = driver.FindElement(by: By.XPath("/html/body/div[2]/form/a"));
            CreateNewEmployee.Click();

            IWebElement Name = driver.FindElement(By.Id("Name"));
            Name.SendKeys("Dinuka Gamage");

            IWebElement Salary = driver.FindElement(By.Id("Salary"));
            Salary.SendKeys("3000");

            IWebElement Duration = driver.FindElement(By.Id("DurationWorked"));
            Duration.SendKeys("20");

            SelectElement Grade = new SelectElement(driver.FindElement(By.Id("Grade")));
            Grade.SelectByValue("2");

            IWebElement Email = driver.FindElement(By.Id("Email"));
            Email.SendKeys("Dinuka002730@gmail.com");

            IWebElement CreateButton = driver.FindElement(by: By.XPath("/html/body/div[2]/form/div/div[6]/div/input"));
            CreateButton.Click();

            Thread.Sleep(5000);



        }

    }
}