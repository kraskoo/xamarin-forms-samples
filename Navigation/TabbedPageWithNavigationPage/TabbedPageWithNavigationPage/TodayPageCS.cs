namespace TabbedPageWithNavigationPage
{
    using Xamarin.Forms;

    public class TodayPageCS : ContentPage
    {
        public TodayPageCS()
        {
            this.IconImageSource = "today.png";
            this.Title = "Today";
            this.Content = new StackLayout
                               {
                                   Children =
                                       {
                                           new Label
                                               {
                                                   Text = "Today's appointments go here",
                                                   HorizontalOptions = LayoutOptions.Center,
                                                   VerticalOptions = LayoutOptions.CenterAndExpand
                                               }
                                       }
                               };
        }
    }
}