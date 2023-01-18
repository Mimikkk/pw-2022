namespace Tests;

[TestFixture]
public class GoodE2ETestTest : ViewTest {
  [Test]
  public void ShouldBeVisitable() {
    _driver.Navigate().GoToUrl(BaseUrl);

    _driver.FindById("navigate-to-goods", 5).Click();

    Assert.AreEqual(_driver.Url, $"{BaseUrl}/goods");
  }
}
