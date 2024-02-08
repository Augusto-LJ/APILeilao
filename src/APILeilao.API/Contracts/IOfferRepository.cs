using APILeilao.API.Entities;

namespace APILeilao.API.Contracts
{
    public interface IOfferRepository
    {
        void Add(Offer offer);
    }
}
