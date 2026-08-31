using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.ElevenLabs.HttpClients.Abstract;

/// <summary>
/// Provides the configured HTTP client used to call the ElevenLabs API.
/// </summary>
public interface IElevenLabsOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the shared ElevenLabs HTTP client.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The configured HTTP client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
