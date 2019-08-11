namespace TabbedPageWithNavigationPage
{
    using System;

    using Xamarin.Forms;

    public class UpcomingAppointmentsPageCS : ContentPage
    {
        public UpcomingAppointmentsPageCS()
        {
            var button = new Button { Text = "Back", VerticalOptions = LayoutOptions.CenterAndExpand };
            button.Clicked += this.OnBackButtonClicked;

            this.Title = "Upcoming";
            this.Content = new StackLayout
                               {
                                   Children =
                                       {
                                           new Label
                                               {
                                                   Text = "Upcoming appointments go here",
                                                   HorizontalOptions = LayoutOptions.Center,
                                                   VerticalOptions = LayoutOptions.CenterAndExpand
                                               },
                                           button
                                       }
                               };
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}