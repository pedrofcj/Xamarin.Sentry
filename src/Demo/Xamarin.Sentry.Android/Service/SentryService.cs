using IO.Sentry.Event;
using Java.Lang;
using Xamarin.Forms;
using Xamarin.Sentry.Droid.Service;
using Xamarin.Sentry.Service;

[assembly: Dependency(typeof(SentryService))]
namespace Xamarin.Sentry.Droid.Service
{
    public class SentryService : ISentryService
    {
        #region ISentryService

        public void Init(string key)
        {
            IO.Sentry.Sentry.Init(key);
        }

        public void Info(string message)
        {
            Generic(Event.Level.Info, message);
        }

        public void Warning(string message)
        {
            Generic(Event.Level.Warning, message);
        }

        public void Error(string message)
        {
            Generic(Event.Level.Error, message);
        }

        public void Fatal(string message)
        {
            Generic(Event.Level.Fatal, message);
        }

        public void Exception(System.Exception ex)
        {
            IO.Sentry.Sentry.Capture(Throwable.FromException(ex));
        }

        #endregion

        #region Private

        private void Generic(Event.Level level, string message)
        {
            var eventBuilder = new EventBuilder()
                .WithMessage(message)
                .WithLevel(level);
            IO.Sentry.Sentry.Capture(eventBuilder);

        }

        #endregion

    }
}