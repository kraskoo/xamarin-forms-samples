namespace NavigationPageTitleView
{
    using System;
    using System.Windows.Input;

    using Xamarin.Forms;

    public partial class AndroidExtendedTitleViewPage : ContentPage
    {
        private readonly ICommand returnToMenuPage;

        public AndroidExtendedTitleViewPage(ICommand restore)
        {
            this.InitializeComponent();

            this.returnToMenuPage = restore;
        }

        private void OnReturnButtonClicked(object sender, EventArgs e)
        {
            this.returnToMenuPage.Execute(null);
        }
    }
}