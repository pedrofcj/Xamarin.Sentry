using System;

namespace Xamarin.Sentry.Service
{
    public interface ISentryService
    {
        void Init(string key);
        void Info(string message);
        void Warning(string message);
        void Error(string message);
        void Fatal(string message);
        void Exception(Exception ex);

    }
}