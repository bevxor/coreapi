using CoreApi.Common.Contract;

namespace CoreApi.Common.AppSettings
{
    public class AppSettings : IAppSettings
    {
        public string SomeConfigValue { get; set; }
    }
}
