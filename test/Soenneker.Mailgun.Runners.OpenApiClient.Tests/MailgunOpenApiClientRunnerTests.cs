using Soenneker.Tests.HostedUnit;

namespace Soenneker.Mailgun.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MailgunOpenApiClientRunnerTests : HostedUnitTest
{
    public MailgunOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
