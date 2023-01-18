using OpenQA.Selenium.Support.UI;

namespace Tests.E2Es;

[TestFixture]
public class RaceE2ETestTest : E2ETest {

  [Test, Order(1)]
  public void ShouldCreateNewRace() {
    _driver.Navigate().GoToUrl(RacesUrl);
    _driver.FindById("open-create-race-modal").Click();

    _driver.FindById("name").SendKeys(RaceName);
    _driver.FindById("description").SendKeys("race-description");
    _driver.FindElement(By.CssSelector("select[data-testid=needs] option[value=low]")).Click();
    _driver.FindElement(By.CssSelector("select[data-testid=decadency] option[value=low]")).Click();
    _driver.FindElement(By.CssSelector("select[data-testid=will] option[value=low]")).Click();
    _driver.FindElement(By.CssSelector("button[type=submit]")).Click();
    
    _driver.FindByText(RaceName);
  }

  [Test, Order(2)]
  public void ShouldViewCreatedRace() {
    _driver.Navigate().GoToUrl(RacesUrl);

    _driver.FindById($"navigate-to-race-{RaceName}").Click();

    Assert.AreEqual(_driver.Url, $"{RacesUrl}/{RaceName}");
  }

  [Test, Order(3)]
  public void ShouldEditNewRace() {
    _driver.Navigate().GoToUrl(RacesUrl);

    _driver.FindById($"open-edit-race-{RaceName}-modal").Click();
    _driver.FindById("description").SendKeys("edit");
    _driver.FindElement(By.CssSelector("select[data-testid=needs] option[value=high]")).Click();
    _driver.FindElement(By.CssSelector("select[data-testid=decadency] option[value=high]")).Click();
    _driver.FindElement(By.CssSelector("select[data-testid=will] option[value=high]")).Click();
    _driver.FindElement(By.CssSelector("button[type=submit]")).Click();
  }

  [Test, Order(4)]
  public void ShouldRemoveEditedRace() {
    _driver.Navigate().GoToUrl(RacesUrl);

    _driver.FindById($"open-remove-race-{RaceName}-modal").Click();
    _driver.FindById("confirm-confirmation-modal").Click();
  }

  private const string RaceName = "race-name";
  private const string RacesUrl = $"{BaseUrl}/races";
}
