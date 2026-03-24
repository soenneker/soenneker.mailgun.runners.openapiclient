using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Mailgun.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class MailgunOpenApiClientRunnerTests : FixturedUnitTest
{
    public MailgunOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
