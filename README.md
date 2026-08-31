[![](https://img.shields.io/nuget/v/soenneker.elevenlabs.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.elevenlabs.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.elevenlabs.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.elevenlabs.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.elevenlabs.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.elevenlabs.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.elevenlabs.httpclients/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.elevenlabs.httpclients/actions/workflows/codeql.yml)

# Soenneker.ElevenLabs.HttpClients

Provides a cached `HttpClient` configured for ElevenLabs authentication and API requests.

## Installation

```bash
dotnet add package Soenneker.ElevenLabs.HttpClients
```

## Configuration

```json
{
  "ElevenLabs": {
    "ApiKey": "your-api-key"
  }
}
```

Requests use the `xi-api-key` header and `https://api.elevenlabs.io/` by default. `ElevenLabs:AuthHeaderName`, `ElevenLabs:AuthHeaderValueTemplate`, and `ElevenLabs:ClientBaseUrl` can override those values when needed.

## Registration and usage

```csharp
using Soenneker.ElevenLabs.HttpClients.Abstract;
using Soenneker.ElevenLabs.HttpClients.Registrars;

services.AddElevenLabsOpenApiHttpClientAsSingleton();

public sealed class ElevenLabsRequestSender(IElevenLabsOpenApiHttpClient clients)
{
    public async Task<HttpResponseMessage> GetVoices(CancellationToken cancellationToken)
    {
        HttpClient client = await clients.Get(cancellationToken);
        return await client.GetAsync("v1/voices", cancellationToken);
    }
}
```

Use the scoped registration only when each scope must own a separate client. Each provider instance owns its cache entry and removes that client when disposed.
