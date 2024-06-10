using Ardalis.Result;
using Ardalis.SharedKernel;

namespace dotnet.microservice.blueprint.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
