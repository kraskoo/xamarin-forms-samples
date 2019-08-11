namespace NavigationPageTitleView
{
    using Xamarin.Forms;

    public partial class iOSNavigationPage : NavigationPage
    {
        public iOSNavigationPage(Page page)
        {
            this.InitializeComponent();
            this.PushAsync(page);
        }
    }
}