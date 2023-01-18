using OpenQA.Selenium.Support.UI;

namespace Tests;

public static class WebDriverExtensions {
  public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds) {
    if (timeoutInSeconds <= 0) return driver.FindElement(by);
    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
    return wait.Until(drv => drv.FindElement(by));
  }

  public static IWebElement FindById(this IWebDriver driver, string testId, int timeout) =>
    driver.FindElement(By.CssSelector($":is([data-testid='{testId}'], [id='${testId}'])"), timeout);
}
