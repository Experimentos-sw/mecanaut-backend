using AwawaTech.Mecanaut.API.Shared.Domain.Model.Entities;

namespace AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Aggregates;

public class ExperimentLog : AuditableEntity
{
    public string ExperimentName { get; private set; }
    public string Variant { get; private set; }
    public string ActionType { get; private set; }
    public long? DurationMilliseconds { get; private set; }
    public bool IsSuccess { get; private set; }
    public string? AdditionalData { get; private set; }

    protected ExperimentLog()
    {
        ExperimentName = string.Empty;
        Variant = string.Empty;
        ActionType = string.Empty;
    }

    public ExperimentLog(
        string experimentName,
        string variant,
        string actionType,
        long? durationMilliseconds,
        bool isSuccess,
        string? additionalData)
    {
        if (string.IsNullOrWhiteSpace(experimentName))
            throw new ArgumentException("Experiment name is required.", nameof(experimentName));

        if (string.IsNullOrWhiteSpace(variant))
            throw new ArgumentException("Variant is required.", nameof(variant));

        if (string.IsNullOrWhiteSpace(actionType))
            throw new ArgumentException("Action type is required.", nameof(actionType));

        ExperimentName = experimentName.Trim();
        Variant = variant.Trim();
        ActionType = actionType.Trim();
        DurationMilliseconds = durationMilliseconds;
        IsSuccess = isSuccess;
        AdditionalData = additionalData?.Trim();
    }
}