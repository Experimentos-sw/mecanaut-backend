using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Services;
using AwawaTech.Mecanaut.API.TelemetryManagement.Interfaces.REST.Resources;
using AwawaTech.Mecanaut.API.TelemetryManagement.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;

namespace AwawaTech.Mecanaut.API.TelemetryManagement.Interfaces.REST;

[ApiController]
[Route("api/v1/experiment-telemetry")]
public class ExperimentTelemetryController : ControllerBase
{
    private readonly IExperimentLogCommandService commandService;

    public ExperimentTelemetryController(IExperimentLogCommandService commandService)
    {
        this.commandService = commandService;
    }

    [HttpPost]
    public async Task<IActionResult> RecordMetric([FromBody] TelemetryResource resource)
    {
        var log = await commandService.Handle(RecordExperimentLogCommandFromResourceAssembler.ToCommandFromResource(resource));

        return Ok(new { message = "Metrica del experimento registrada exitosamente.", id = log.Id });
    }
}