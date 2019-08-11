namespace NavigationPageTitleView
{
    using Xamarin.Forms;

    public partial class AndroidNavigationPage : NavigationPage
    {
        public AndroidNavigationPage(Page page)
        {
            this.InitializeComponent();
            this.PushAsync(page);
        }
    }
}