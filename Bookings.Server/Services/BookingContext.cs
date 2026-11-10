// 

using Bookings.Contracts;
using Microsoft.EntityFrameworkCore;

public class BookingsContext : DbContext {
    public DbSet<TestEntity> TestEntities => Set<TestEntity>();

    public BookingsContext(DbContextOptions<BookingsContext> options) : base(options)
    {
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     // This creates a local SQLite file named "blogming.db" in your application directory
    //     optionsBuilder.UseSqlite("Data Source=../Bookings.Database/booking.db");
    // }
}