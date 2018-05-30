using Xamarin.Forms;
namespace Xamarin.Sentry
{
    public class SentryInitHelper
    {
        private static string AndroidKey = "ADD YOUR KEY HERE";
        private static string IosKey = "ADD YOUR KEY HERE";
        public static string SentryKey => Device.RuntimePlatform == Device.Android ? AndroidKey : IosKey;
    }
}