using System;
using System.Reflection;

namespace CoreApi.Common.AppSettings
{
    public class AppSettings : IAppSettings
    {
        public string RaygunKey { get; set; }
    
        private static string AppSetting(string key)
        {
            return String.Empty;
        }
    }
}
