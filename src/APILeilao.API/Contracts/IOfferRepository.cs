using APILeilao.API.Entities;

namespace APILeilao.API.Contracts
{
    public interface IOfferRepository
    {
        void Add(Offer offer);
        Offer Get(int offerId);
        void Delete(int offerId);
    }
}
