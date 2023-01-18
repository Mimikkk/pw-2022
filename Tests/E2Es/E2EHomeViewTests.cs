namespace Tests.E2Es;

[TestFixture]
public class HomeE2EE2ETests : E2ETest {
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

  [Test]
  public void ShouldGoBackByBreadCrumbs() {
    _driver.Navigate().GoToUrl(BaseUrl);

    _driver.FindById("navigate-to-races", 5).Click();

    Assert.AreEqual(_driver.Url, $"{BaseUrl}/races");

    _driver.FindById("navigate-to-home", 5).Click();

    Assert.AreEqual(_driver.Url, $"{BaseUrl}/");
  }
}
