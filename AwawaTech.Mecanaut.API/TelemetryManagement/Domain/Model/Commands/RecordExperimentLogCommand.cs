namespace AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Commands;

public record RecordExperimentLogCommand(
    string ExperimentName,
    string Variant,
    string ActionType,
    long? DurationMilliseconds,
    bool IsSuccess,
    string? AdditionalData);