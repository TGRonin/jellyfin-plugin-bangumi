using MediaBrowser.Common.Configuration;

namespace Jellyfin.Plugin.Bangumi.Test.Mock;

public class MockedApplicationPaths : IApplicationPaths
{
    private static readonly string BasePath = Util.FakePath.Create("application-data");

    public string ProgramDataPath => BasePath;
    public string WebPath => BasePath;
    public string ProgramSystemPath => BasePath;
    public string DataPath => BasePath;
    public string ImageCachePath => BasePath;
    public string PluginsPath => BasePath;
    public string PluginConfigurationsPath => BasePath;
    public string LogDirectoryPath => BasePath;
    public string ConfigurationDirectoryPath => BasePath;
    public string SystemConfigurationFilePath => BasePath;
    public string CachePath => BasePath;
    public string TempDirectory => BasePath;
    public string VirtualDataPath => BasePath;
}
