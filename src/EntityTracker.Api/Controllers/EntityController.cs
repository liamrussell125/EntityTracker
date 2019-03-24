using System.Threading.Tasks;
using EntityTracker.Interfaces.Services;
using EntityTracker.ViewModels.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityTracker.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IEntityTrackerService entityTrackerService;

        public EntityController(IEntityTrackerService entityTrackerService)
        {
            this.entityTrackerService = entityTrackerService;
        }

        [HttpGet("{entityId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetEntity(string entityId)
        {
            var entity = await entityTrackerService.GetTrackedEntity(entityId);

            if(entity == null)
            {
                return NotFound();
            }

            return Ok(ViewEntityVM.FromTrackedEntityDto(entity));
        }

        [HttpPost("event")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> AddEntityEvent(CreateEntityEventVM createEntityVM)
        {
            try
            {
                await entityTrackerService.SaveTrackedEntityEvent(createEntityVM.EntityId, createEntityVM.ServiceId);
                var progressUrl = Url.RouteUrl("", new { entityId = createEntityVM.EntityId });
                return Accepted(progressUrl);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}