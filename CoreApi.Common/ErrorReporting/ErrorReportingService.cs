using CoreApi.Common.AppSettings;
using CoreApi.Common.Contract;

namespace CoreApi.Common.ErrorReporting
{
    public class ErrorReportingService
    {
        private readonly IAppSettings _appSettings;

        public ErrorReportingService(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
    }
}