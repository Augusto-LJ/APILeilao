using APILeilao.API.Entities;

namespace APILeilao.API.Contracts
{
    public interface IAuctionRepository
    {
        Auction? GetCurrent();
    }
}
