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

        public void Delete(int offerId)
        {
            var offer = _dbContext.Offers.FirstOrDefault(o => o.Id == offerId);

            try
            {
                _dbContext?.Offers.Remove(offer);
                _dbContext?.SaveChanges();
            }
            catch
            {
                throw new Exception("Offer not found");
            }
        }

        public Offer Get(int offerId)
        {
            try
            {
                return _dbContext.Offers.FirstOrDefault(o => o.Id == offerId);
            }
            catch
            {
                throw new Exception("Offer not found");
            }
            
        }
    }
}
