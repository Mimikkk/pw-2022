namespace Tests;

[TestFixture]
public class HomeViewE2ETests : ViewTest {
  [Test]
  public void ShouldGoodsBeVisitable() {
    _driver.Navigate().GoToUrl(BaseUrl);

    _driver.FindById("navigate-to-goods", 5).Click();

    Assert.AreEqual(_driver.Url, $"{BaseUrl}/goods");
  }
  [Test]
  public void ShouldRacesBeVisitable() {
    _driver.Navigate().GoToUrl(BaseUrl);

    _driver.FindById("navigate-to-races", 5).Click();

    Assert.AreEqual(_driver.Url, $"{BaseUrl}/races");
  }
}
