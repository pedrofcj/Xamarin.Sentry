using System;
using Xamarin.Forms;
using Xamarin.Sentry.Service;

namespace Xamarin.Sentry
{
    public partial class MainPage : ContentPage
    {
        private readonly ISentryService _sentryService = DependencyService.Get<ISentryService>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void SendInfoButton(object sender, EventArgs e)
        {
            _sentryService.Info(txtMessage.Text);
        }

        private void SendWarningButton(object sender, EventArgs e)
        {
            _sentryService.Warning(txtMessage.Text);
        }

        private void SendErrorButton(object sender, EventArgs e)
        {
            _sentryService.Error(txtMessage.Text);
        }

        private void SendFatalButton(object sender, EventArgs e)
        {
            _sentryService.Fatal(txtMessage.Text);
        }

        private void SendExceptionButton(object sender, EventArgs e)
        {
            try
            {
                throw new Exception(txtMessage.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                _sentryService.Exception(ex);
            }
        }

    }
}
