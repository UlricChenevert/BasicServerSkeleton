namespace Booking.Tests;

public class SetupTests
{
    [Fact]
    public async Task BasicTestHttpRequestAsync()
    {
        // Arrange
        var client = new HttpClient();

        // Act
        var response = await client.GetAsync("http://localhost:5212/api/Test/HelloWorld", TestContext.Current.CancellationToken);

        var body = await response.Content.ReadAsStringAsync(TestContext.Current.CancellationToken);

        // Assert
        Assert.True(body == "Hello!");
    }
}
