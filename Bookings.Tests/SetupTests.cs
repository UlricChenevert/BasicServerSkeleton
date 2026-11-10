using System.Net.Http.Json;
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
        var response = await client.GetAsync("http://localhost:5212/api/Tests/HelloWorld");

        var body = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.True(body == "Hello!");
    }

    [Fact]
    public async Task BasicServiceTestAsync()
    {
        // Arrange
        var client = new HttpClient();

        // Act
        var response = await client.GetAsync("http://localhost:5212/api/Tests/HelloService");

        var body = await response.Content.ReadAsStringAsync();

        // Assert
        Assert.True(body == "AHHHHHHHHHH IM BURNING");
    }

    [Fact]
    public async Task BasicDatabaseAsync()
    {
        // Arrange
        var client = new HttpClient();

        // Act
        var response = await client.GetAsync("http://localhost:5212/api/Tests/HelloDatabase");

        var body = await response.Content.ReadFromJsonAsync<bool>();

        // Assert
        Assert.True(body = true);
    }
}
