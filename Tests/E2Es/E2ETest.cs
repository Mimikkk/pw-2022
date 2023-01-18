using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Tests.E2Es;

public class E2ETest {

  [SetUp]
  public void SetUp()
    => _driver = new ChromeDriver(new DriverManager().SetUpDriver(new ChromeConfig()));

  [TearDown]
  protected void TearDown() => _driver.Quit();

  protected const string BaseUrl = "http://localhost:5116";
  protected IWebDriver _driver = null!;
}
