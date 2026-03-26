using Soenneker.ElevenLabs.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ElevenLabs.HttpClients.Tests;

[Collection("Collection")]
public sealed class ElevenLabsOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IElevenLabsOpenApiHttpClient _httpclient;

    public ElevenLabsOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IElevenLabsOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
