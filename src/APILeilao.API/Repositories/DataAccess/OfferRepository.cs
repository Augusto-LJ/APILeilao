using APILeilao.API.Contracts;
using APILeilao.API.Entities;

namespace APILeilao.API.Repositories.DataAccess
{
    public class OfferRepository : IOfferRepository
    {
        private readonly APILeilaoDbContext _dbContext;
        public OfferRepository(APILeilaoDbContext dbContext) => _dbContext = dbContext;

        public void Add(Offer offer)
        {
            _dbContext.Offers.Add(offer);

            _dbContext.SaveChanges();
        }
    }
}
