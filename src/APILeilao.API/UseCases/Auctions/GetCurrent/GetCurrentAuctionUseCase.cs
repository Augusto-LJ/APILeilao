using Microsoft.EntityFrameworkCore;
using APILeilao.API.Entities;
using APILeilao.API.Repositories;

namespace APILeilao.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction? Execute()
        {
            var repository = new APILeilaoDbContext();

            var today = DateTime.Now;

            return repository
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
        }
    }
}
