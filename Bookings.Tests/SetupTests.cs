using Xunit;

namespace Booking.Tests;

public class SetupTests
{
    [Fact]
    public async Task BasicTestHttpRequestAsync()
    {
        // Arrange
        var client = new HttpClient();

        // Act
        var response = await client.GetAsync("http://localhost:5001/api/Test/HelloWorld");

        var body = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.True(body == "Hello!");
    }
}
