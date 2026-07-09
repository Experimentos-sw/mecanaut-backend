using System.ComponentModel.DataAnnotations;

namespace AwawaTech.Mecanaut.API.TelemetryManagement.Interfaces.REST.Resources;

public record TelemetryResource(
    [Required] string ExperimentName,
    [Required] string Variant,
    [Required] string ActionType,
    long? DurationMilliseconds,
    [Required] bool IsSuccess,
    string? AdditionalData);