using Ardalis.Result;

namespace dotnet.microservice.blueprint.UseCases.Contributors.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateContributorCommand(string Name, string? PhoneNumber) : Ardalis.SharedKernel.ICommand<Result<int>>;
