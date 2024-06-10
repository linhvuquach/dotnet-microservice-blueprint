namespace dotnet.microservice.blueprint.Web.Contributors;

public class UpdateContributorResponse(ContributorRecord contributor)
{
  public ContributorRecord Contributor { get; set; } = contributor;
}
