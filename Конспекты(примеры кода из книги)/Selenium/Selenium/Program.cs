using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

// 1. Start the session
IWebDriver driver = new ChromeDriver();

// 2. Take action on browser
driver.Navigate().GoToUrl("https://xlastnightx.github.io/RadioW-Wave/");

// 3. Request browser information
var title = driver.Title;

// 4. Establish Waiting Strategy (Manage - опции предоставляющие доступ к меню браузера)
// implicit (ждет возможность действия)
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(500);

// explicit (ждет прогрузку элемента)
WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

// Исключение
wait.Until(d => {
    try
    {
        driver.FindElement(By.Id("submit-btn"));
    }
    catch (Exception ex) 
    {
        Console.WriteLine("Возникла ошибка:" +  ex.Message);
    }

    return true;
});

// или можно так
// fluent
DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);

fluentWait.Timeout = TimeSpan.FromSeconds(8);
fluentWait.Until(d => {
    int test = driver.FindElements(By.Id("email1")).ToList().Count();

    // Новое сключение
    if (test <= 0)
    {
        throw new Exception("Такого элеметна не существует");
    }
    return true;
});


// 5. Find an element
var textBox = driver.FindElement(By.Name("comment"));
var submitButton = driver.FindElement(By.Id("submit-btn"));

// 6. Take action on element
textBox.SendKeys("Selenium");
submitButton.Click();

// 7. Request element information
var message = driver.FindElement(By.TagName("h2"));
var value = message.Text;

Console.WriteLine($"{value} h2");
Console.WriteLine($"{title} title");

// Timer
var stopwatch = new Stopwatch();

stopwatch.Start();
Thread.Sleep(9000);
stopwatch.Stop();

Console.WriteLine("Time is out, thanks for comming!");

// 8. End the session
driver.Quit();