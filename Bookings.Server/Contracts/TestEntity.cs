using System.ComponentModel.DataAnnotations;

namespace Bookings.Contracts;

public class TestEntity
{
    [Key]
    public required string Hello {get; init;}
    public required string World {get; init;}
}