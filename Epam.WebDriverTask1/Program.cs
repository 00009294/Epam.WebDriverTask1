
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    public static void Main(string[] args)
    {
        var driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://pastebin.com/");
        driver.Manage().Window.Maximize();

        driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[1]/a[2]")).Click();

        driver.FindElement(By.Id("postform-text")).SendKeys("Hello from WebDriver");

        driver.FindElement(By.Id("select2-postform-expiration-result-iry5-10M")).Click();

        driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/form/div[5]/div[1]/div[9]/div/input")).SendKeys("helloweb");

        driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/form/div[5]/div[1]/div[10]/button")).Click();
    }
}
