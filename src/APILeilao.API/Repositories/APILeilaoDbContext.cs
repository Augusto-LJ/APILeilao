using Microsoft.EntityFrameworkCore;
using APILeilao.API.Entities;

namespace APILeilao.API.Repositories
{
    public class APILeilaoDbContext : DbContext
    {
        public APILeilaoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}
