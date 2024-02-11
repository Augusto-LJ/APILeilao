using APILeilao.API.Communication.Requests;
using APILeilao.API.Contracts;
using APILeilao.API.Entities;
using APILeilao.API.Services;
using APILeilao.API.UseCases.Offers.CreateOffer;
using Bogus;
using FluentAssertions;
using Moq;
using Xunit;

namespace UseCases.Test.Offers.CreateOffer
{
    public class CreateOfferUseCaseTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void Success(int itemID)
        {
            //ARANGE
            var request = new Faker<RequestCreateOfferJson>()
                .RuleFor(request => request.Price, f => f.Random.Decimal(1, 700)).Generate();

            var offerRepository = new Mock<IOfferRepository>();
            var loggedUser = new Mock<ILoggedUser>();
            loggedUser.Setup(i => i.User()).Returns(new User());

            var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

            //ACT
            var act = () => useCase.Execute(itemID, request);

            //ASSERT
            act.Should().NotThrow();

        }
    }
}
