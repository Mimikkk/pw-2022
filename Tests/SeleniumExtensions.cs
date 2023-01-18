using OpenQA.Selenium.Support.UI;

namespace Tests;

public static class WebDriverExtensions {
  public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds) {
    if (timeoutInSeconds <= 0) return driver.FindElement(by);
    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
    return wait.Until(drv => drv.FindElement(by));
  }

  public static IWebElement FindById(this IWebDriver driver, string testId, int timeout = 5) =>
    driver.FindElement(By.CssSelector($"[data-testid='{testId}']"), timeout);
  public static IWebElement FindByText(this IWebDriver driver, string text, int timeout = 5) =>
    driver.FindElement(By.XPath($"//*[text()='{text}']"), timeout);

  public static void Debug(this IWebDriver driver) {
    var js = (IJavaScriptExecutor)driver;
    js.ExecuteScript("console.log(document.documentElement.outerHTML)");
    driver.FindById("invalid-id", 100);
  }
}
