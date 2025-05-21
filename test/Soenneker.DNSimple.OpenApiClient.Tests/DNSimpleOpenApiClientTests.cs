using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.DNSimple.OpenApiClient.Tests;

[Collection("Collection")]
public class DNSimpleOpenApiClientTests : FixturedUnitTest
{

    public DNSimpleOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {

    }

    [Fact]
    public void Default()
    {

    }
}
