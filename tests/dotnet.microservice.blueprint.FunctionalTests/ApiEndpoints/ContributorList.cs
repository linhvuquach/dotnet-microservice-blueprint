using Ardalis.HttpClientTestExtensions;
using dotnet.microservice.blueprint.Infrastructure.Data;
using dotnet.microservice.blueprint.Web.Contributors;
using Xunit;

namespace dotnet.microservice.blueprint.FunctionalTests.ApiEndpoints;

[Collection("Sequential")]
public class ContributorList(CustomWebApplicationFactory<Program> factory) : IClassFixture<CustomWebApplicationFactory<Program>>
{
  private readonly HttpClient _client = factory.CreateClient();

  [Fact]
  public async Task ReturnsTwoContributors()
  {
    var result = await _client.GetAndDeserializeAsync<ContributorListResponse>("/Contributors");

    Assert.Equal(2, result.Contributors.Count);
    Assert.Contains(result.Contributors, i => i.Name == SeedData.Contributor1.Name);
    Assert.Contains(result.Contributors, i => i.Name == SeedData.Contributor2.Name);
  }
}
