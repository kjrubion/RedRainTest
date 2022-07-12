using Microsoft.AspNetCore.Mvc;
using RedRain.Domain.Common;
using RedRain.Domain.Query;
using RedRain.Domain.Repositories;

namespace RedRainTest.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        /// <summary>
        /// Gets the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="service">The service.</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status412PreconditionFailed)]
        [ProducesResponseType(StatusCodes.Status428PreconditionRequired)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public GenericResult Get([FromQuery] EntityRequest request,
            [FromServices] EntityQuery service) => service.Get(request);
    }
}
