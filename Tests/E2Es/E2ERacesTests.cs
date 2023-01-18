namespace Tests.E2Es;

[TestFixture]
public class RaceE2ETestTest : E2ETest {

  [Test, Order(1)]
  public void ShouldCreateNewRace() {
    _driver.Navigate().GoToUrl(RacesUrl);

  }

  [Test, Order(2)]
  public void ShouldViewCreatedRace() {
    _driver.Navigate().GoToUrl(RacesUrl);
  }

  [Test, Order(3)]
  public void ShouldEditNewRace() {
    _driver.Navigate().GoToUrl(RacesUrl);
  }

  [Test, Order(4)]
  public void ShouldViewEditedRace() {
    _driver.Navigate().GoToUrl(RacesUrl);
  }

  [Test, Order(5)]
  public void ShouldRemoveEditedRace() {
    _driver.Navigate().GoToUrl(RacesUrl);
  }

  private const string RacesUrl = $"{BaseUrl}/races";
}
