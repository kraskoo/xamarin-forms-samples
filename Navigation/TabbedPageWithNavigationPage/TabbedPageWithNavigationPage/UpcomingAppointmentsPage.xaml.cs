namespace TabbedPageWithNavigationPage
{
    using System;

    using Xamarin.Forms;

    public partial class UpcomingAppointmentsPage : ContentPage
    {
        public UpcomingAppointmentsPage()
        {
            this.InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}