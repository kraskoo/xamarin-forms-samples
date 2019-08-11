namespace MasterDetailPageNavigation
{
    using System;

    using Xamarin.Forms;

    public class MainPageCs : MasterDetailPage
    {
        private readonly MasterPageCs masterPage;

        public MainPageCs()
        {
            this.masterPage = new MasterPageCs();
            this.Master = this.masterPage;
            this.Detail = new NavigationPage(new ContactsPageCs());

            this.masterPage.ListView.ItemSelected += this.OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                this.MasterBehavior = MasterBehavior.Popover;
            }
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                this.Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                this.masterPage.ListView.SelectedItem = null;
                this.IsPresented = false;
            }
        }
    }
}