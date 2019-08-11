namespace TabbedPageWithNavigationPage
{
    using System;

    using Xamarin.Forms;

    public class SchedulePageCS : ContentPage
    {
        public SchedulePageCS()
        {
            var button = new Button { Text = "Upcoming Appointments", VerticalOptions = LayoutOptions.CenterAndExpand };
            button.Clicked += this.OnUpcomingAppointmentsButtonClicked;

            this.Title = "This Week";
            this.Content = new StackLayout
                               {
                                   Children =
                                       {
                                           new Label
                                               {
                                                   Text = "This week's appointments go here",
                                                   HorizontalOptions = LayoutOptions.Center,
                                                   VerticalOptions = LayoutOptions.CenterAndExpand
                                               },
                                           button
                                       }
                               };
        }

        private async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new UpcomingAppointmentsPage());
        }
    }
}