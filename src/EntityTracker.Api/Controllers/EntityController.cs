using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityTracker.ViewModels.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityTracker.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        [HttpGet("{entityId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetEntity(string entityId)
        {
            var response = new ViewEntityVM();
            return Ok(response);
        }

        [HttpPost("event")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> AddEntityEvent(CreateEntityEventVM createEntityVM)
        {
            var progressUrl = Url.RouteUrl("", new { entityId = "" });
            return Accepted(progressUrl);
        }
    }
}