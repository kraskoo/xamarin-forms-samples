namespace MasterDetailPageNavigation
{
    using System;

    using Xamarin.Forms;

    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.masterPage.listView.ItemSelected += this.OnItemSelected;
            if (Device.RuntimePlatform == Device.UWP)
            {
                this.MasterBehavior = MasterBehavior.Popover;
            }
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (!(e.SelectedItem is MasterPageItem item))
            {
                return;
            }

            this.Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            this.masterPage.listView.SelectedItem = null;
            this.IsPresented = false;
        }
    }
}