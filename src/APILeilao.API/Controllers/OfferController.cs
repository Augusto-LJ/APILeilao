using APILeilao.API.Communication.Requests;
using APILeilao.API.Filters;
using APILeilao.API.UseCases.Offers.CreateOffer;
using APILeilao.API.UseCases.Offers.DeleteOffer;
using Microsoft.AspNetCore.Mvc;

namespace APILeilao.API.Controllers
{
    [ServiceFilter(typeof(AuthenticationUserAttribute))]
    public class OfferController : APILeilaoBaseController
    {
        [HttpPost]
        [Route("{itemId}")]
        public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request, [FromServices] CreateOfferUseCase useCase)
        {
            var id = useCase.Execute(itemId, request);

            return Created(string.Empty, id);
        }

        [HttpDelete]
        [Route("{offerId}")]
        public IActionResult DeleteOffer([FromRoute] int offerId, [FromServices] DeleteOfferUseCase useCase)
        {
            useCase.Execute(offerId);
            
            return Ok();
        }
    }
}
