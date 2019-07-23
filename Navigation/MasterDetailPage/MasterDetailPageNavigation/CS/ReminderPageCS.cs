namespace MasterDetailPageNavigation
{
    using Xamarin.Forms;

    public class ReminderPageCs : ContentPage
    {
        public ReminderPageCs()
        {
            this.Title = "Reminder Page";
            this.Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Reminder data goes here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}