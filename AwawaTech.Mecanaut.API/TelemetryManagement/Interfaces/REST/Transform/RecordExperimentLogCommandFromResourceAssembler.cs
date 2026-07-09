using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Commands;
using AwawaTech.Mecanaut.API.TelemetryManagement.Interfaces.REST.Resources;

namespace AwawaTech.Mecanaut.API.TelemetryManagement.Interfaces.REST.Transform;

public static class RecordExperimentLogCommandFromResourceAssembler
{
    public static RecordExperimentLogCommand ToCommandFromResource(TelemetryResource resource)
        => new(
            resource.ExperimentName,
            resource.Variant,
            resource.ActionType,
            resource.DurationMilliseconds,
            resource.IsSuccess,
            resource.AdditionalData);
}