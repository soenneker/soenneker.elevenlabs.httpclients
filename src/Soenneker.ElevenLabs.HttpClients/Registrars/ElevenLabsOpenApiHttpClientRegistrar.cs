using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.ElevenLabs.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.ElevenLabs.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class ElevenLabsOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="ElevenLabsOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddElevenLabsOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IElevenLabsOpenApiHttpClient, ElevenLabsOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="ElevenLabsOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddElevenLabsOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IElevenLabsOpenApiHttpClient, ElevenLabsOpenApiHttpClient>();

        return services;
    }
}
