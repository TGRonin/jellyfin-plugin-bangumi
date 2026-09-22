using System.Text.Json;

namespace Jellyfin.Plugin.Bangumi;

public static class Constants
{
    public const string ProviderName = "Bangumi";

    public const string PluginName = "Bangumi for 10.10";

    public const string PluginGuid = "7e0e9030-598d-4709-814e-6a91dfed26f0";

    public const string Language = "zh";

    public static readonly JsonSerializerOptions JsonSerializerOptions = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
}
