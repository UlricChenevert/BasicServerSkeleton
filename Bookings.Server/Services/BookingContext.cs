// 

using Bookings.Contracts;
using Microsoft.EntityFrameworkCore;

public class BookingsContext : DbContext {
    public DbSet<TestEntity> TestEntities => Set<TestEntity>();

    public BookingsContext(DbContextOptions<BookingsContext> options) : base(options)
    {
    }
}