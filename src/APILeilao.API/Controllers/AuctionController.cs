using APILeilao.API.UseCases.Auctions.GetCurrent;
using APILeilao.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APILeilao.API.Controllers
{
    public class AuctionController : APILeilaoBaseController
    {
        [HttpGet]
        [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.Execute();

            if(result is null)
                return NoContent();

            return Ok(result);
        }
    }
}
