using AwawaTech.Mecanaut.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using AwawaTech.Mecanaut.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Model.Aggregates;
using AwawaTech.Mecanaut.API.TelemetryManagement.Domain.Repositories;

namespace AwawaTech.Mecanaut.API.TelemetryManagement.Infrastructure.Persistence.EFC.Repositories;

public class ExperimentLogRepository : BaseRepository<ExperimentLog>, IExperimentLogRepository
{
    public ExperimentLogRepository(AppDbContext context) : base(context)
    {
    }
}