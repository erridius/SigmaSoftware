using Microsoft.EntityFrameworkCore;

namespace BookingService.Models
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<HousePost> HousePosts { get; set; }
        public DbSet<PhotoBank> PhotoBanks { get; set; }
        public DbSet<GuestJournal> Journals { get; set; }


        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении

        }
    }
}
