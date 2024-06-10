using Ardalis.Result;
using Ardalis.SharedKernel;

namespace dotnet.microservice.blueprint.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
