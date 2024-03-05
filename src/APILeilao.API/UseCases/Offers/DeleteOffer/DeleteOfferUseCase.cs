using APILeilao.API.Contracts;
using APILeilao.API.Services;

namespace APILeilao.API.UseCases.Offers.DeleteOffer
{
    public class DeleteOfferUseCase
    {
        private readonly IOfferRepository _repository;

        public DeleteOfferUseCase(ILoggedUser loggedUser, IOfferRepository repository)
        {
            _repository = repository;
        }

        public void Execute(int offerId)
        {
            var existingOffer = _repository.Get(offerId);

            if (existingOffer == null)
            {
                throw new Exception("Offer not found");
            }

            _repository.Delete(offerId);
        }
    }
}
