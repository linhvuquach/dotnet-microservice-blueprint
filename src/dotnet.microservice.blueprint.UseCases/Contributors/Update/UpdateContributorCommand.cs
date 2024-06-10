using Ardalis.Result;
using Ardalis.SharedKernel;

namespace dotnet.microservice.blueprint.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
