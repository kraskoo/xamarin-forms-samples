namespace NavigationPageTitleView.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.LoadApplication(new NavigationPageTitleView.App());
        }
    }
}