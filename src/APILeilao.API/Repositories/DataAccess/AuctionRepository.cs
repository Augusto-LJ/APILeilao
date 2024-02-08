using Microsoft.EntityFrameworkCore;
using APILeilao.API.Entities;
using APILeilao.API.Contracts;

namespace APILeilao.API.Repositories.DataAccess
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly APILeilaoDbContext _dbContext;
        public AuctionRepository(APILeilaoDbContext dbContext) => _dbContext = dbContext;

        public Auction? GetCurrent()
        {
            var today = DateTime.Now;

            return _dbContext
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
        }
    }
}
