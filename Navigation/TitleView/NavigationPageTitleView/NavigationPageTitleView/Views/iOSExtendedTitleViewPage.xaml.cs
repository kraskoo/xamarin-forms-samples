namespace NavigationPageTitleView
{
    using System;
    using System.Windows.Input;

    using Xamarin.Forms;

    public partial class iOSExtendedTitleViewPage : ContentPage
    {
        private readonly ICommand returnToMenuPage;

        public iOSExtendedTitleViewPage(ICommand restore)
        {
            this.InitializeComponent();

            this.returnToMenuPage = restore;
            this._searchBar.Effects.Add(Effect.Resolve("XamarinDocs.SearchBarEffect"));
        }

        private void OnReturnButtonClicked(object sender, EventArgs e)
        {
            this.returnToMenuPage.Execute(null);
        }
    }
}