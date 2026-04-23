using Soenneker.Tests.HostedUnit;

namespace Soenneker.DNSimple.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DNSimpleOpenApiClientTests : HostedUnitTest
{

    public DNSimpleOpenApiClientTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
