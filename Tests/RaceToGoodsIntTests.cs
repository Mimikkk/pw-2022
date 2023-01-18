namespace Tests;

[TestFixture]
public class RaceGoodsIntTests : ViewTest {

  [Test, Order(1)]
  public void ShouldCreateNewRace() {
    _driver.Navigate().GoToUrl(GoodsUrl);

  }

  [Test, Order(2)]
  public void ShouldCreateNewGoods() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  [Test, Order(3)]
  public void ShouldShowGoodsInRace() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  [Test, Order(4)]
  public void ShouldDisallowRaceDeletion() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  [Test, Order(5)]
  public void ShouldRemoveCreatedGoods() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  [Test, Order(6)]
  public void ShouldRemoveCreatedRace() {
    _driver.Navigate().GoToUrl(GoodsUrl);
  }

  private const string GoodsUrl = $"{BaseUrl}/goods";
  private const string RacesUrl = $"{BaseUrl}/races";
}
