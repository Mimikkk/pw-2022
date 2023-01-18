namespace Tests.E2Es;

[TestFixture]
public class GoodE2ETestTest : E2ETest {

  [Test, Order(1)]
  public void ShouldCreateNewGood() {
    _driver.Navigate().GoToUrl(GoodsUrl);

  }

  [Test, Order(2)]
  public void ShouldViewCreatedGood() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  [Test, Order(3)]
  public void ShouldEditNewGood() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  [Test, Order(4)]
  public void ShouldViewEditedGood() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  [Test, Order(5)]
  public void ShouldRemoveEditedGood() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  private const string GoodsUrl = $"{BaseUrl}/goods";
}
