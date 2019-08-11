namespace TabbedPageWithNavigationPage
{
    using Xamarin.Forms;

    public class SettingsPageCS : ContentPage
    {
        public SettingsPageCS()
        {
            this.IconImageSource = "settings.png";
            this.Title = "Settings";
            this.Content = new StackLayout
                               {
                                   Children =
                                       {
                                           new Label
                                               {
                                                   Text = "Settings go here",
                                                   HorizontalOptions = LayoutOptions.Center,
                                                   VerticalOptions = LayoutOptions.CenterAndExpand
                                               }
                                       }
                               };
        }
    }
}