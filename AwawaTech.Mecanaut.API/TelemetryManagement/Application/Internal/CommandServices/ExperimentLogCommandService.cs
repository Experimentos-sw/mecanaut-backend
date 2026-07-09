using AwawaTech.Mecanaut.API.Shared.Domain.Repositories;
using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Aggregates;
using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Commands;
using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Repositories;
using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Services;

namespace AwawaTech.Mecanaut.API.TelemetryManagement.Application.Internal.CommandServices;

public class ExperimentLogCommandService : IExperimentLogCommandService
{
    private readonly IExperimentLogRepository repository;
    private readonly IUnitOfWork unitOfWork;

    public ExperimentLogCommandService(IExperimentLogRepository repository, IUnitOfWork unitOfWork)
    {
        this.repository = repository;
        this.unitOfWork = unitOfWork;
    }

    public async Task<ExperimentLog> Handle(RecordExperimentLogCommand command)
    {
        var log = new ExperimentLog(
            command.ExperimentName,
            command.Variant,
            command.ActionType,
            command.DurationMilliseconds,
            command.IsSuccess,
            command.AdditionalData);

        await repository.AddAsync(log);
        await unitOfWork.CompleteAsync();

        return log;
    }
}