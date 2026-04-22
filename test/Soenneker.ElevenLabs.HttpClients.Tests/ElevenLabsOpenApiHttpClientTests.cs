using Soenneker.ElevenLabs.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.ElevenLabs.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ElevenLabsOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IElevenLabsOpenApiHttpClient _httpclient;

    public ElevenLabsOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IElevenLabsOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
