using Euvic.WebAPI.ResourcesNaming.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Euvic.WebAPI.ResourcesNaming.Controllers
{

    [Route("api/trainings")]
    [ApiController]
    public class TrainingsController : ControllerBase
    {
        // w każdym endpoincie ustaw url do zasobu zgodny z zasadami RESTful API

        [HttpGet("[?]")]
        public IActionResult GetTrainings() => Ok();

        [HttpGet("[?]")]
        public IActionResult GetTrainingAttendees() => Ok();

        [HttpPost("[?]")]
        public IActionResult CreateTraining() => Ok();

        [HttpDelete("[?]")]
        public IActionResult DeleteTraining([FromRoute] int id) => Ok();

        [HttpDelete("[?]")]
        public IActionResult DeleteAttendee([FromRoute] int id) => Ok();

        [HttpPut("[?]")]
        public IActionResult UpdateTraining([FromRoute] int id, [FromBody] UpdateTrainingRequest request) => Ok();

        [HttpPatch("[?]")]
        public IActionResult ChangeTrainingDuration([FromRoute] int id, [FromBody] int durationInMinutes) => Ok();
    }
}