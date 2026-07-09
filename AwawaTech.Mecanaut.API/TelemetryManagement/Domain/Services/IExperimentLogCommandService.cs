using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Aggregates;
using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Commands;

namespace AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Services;

public interface IExperimentLogCommandService
{
    Task<ExperimentLog> Handle(RecordExperimentLogCommand command);
}