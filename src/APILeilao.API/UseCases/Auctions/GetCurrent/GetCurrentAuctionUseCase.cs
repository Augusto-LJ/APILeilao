using APILeilao.API.Contracts;
using APILeilao.API.Entities;

namespace APILeilao.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        private readonly IAuctionRepository _repository;

        public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;
        public Auction? Execute()
        {
            return _repository.GetCurrent();
        }
    }
}
