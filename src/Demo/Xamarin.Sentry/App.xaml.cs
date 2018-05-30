using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Sentry.Service;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin.Sentry
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

            DependencyService.Get<ISentryService>().Init(SentryInitHelper.SentryKey);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
