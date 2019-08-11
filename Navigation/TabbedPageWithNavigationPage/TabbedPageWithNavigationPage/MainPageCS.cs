namespace TabbedPageWithNavigationPage
{
    using Xamarin.Forms;

    public class MainPageCS : TabbedPage
    {
        public MainPageCS()
        {
            var navigationPage = new NavigationPage(new SchedulePageCS());
            navigationPage.IconImageSource = "schedule.png";
            navigationPage.Title = "Schedule";

            this.Children.Add(new TodayPageCS());
            this.Children.Add(navigationPage);
            this.Children.Add(new SettingsPage());
        }
    }
}