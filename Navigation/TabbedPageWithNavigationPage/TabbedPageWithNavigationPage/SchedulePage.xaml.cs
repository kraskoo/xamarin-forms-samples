namespace TabbedPageWithNavigationPage
{
    using System;

    using Xamarin.Forms;

    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            this.InitializeComponent();
        }

        private async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new UpcomingAppointmentsPage());
        }
    }
}