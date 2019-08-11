namespace MasterDetailPageNavigation
{
    using Xamarin.Forms;

    public class ContactsPageCs : ContentPage
    {
        public ContactsPageCs()
        {
            this.Title = "Contacts Page";
            this.Content = new StackLayout
                               {
                                   Children =
                                       {
                                           new Label
                                               {
                                                   Text = "Contacts data goes here",
                                                   HorizontalOptions = LayoutOptions.Center,
                                                   VerticalOptions = LayoutOptions.CenterAndExpand
                                               }
                                       }
                               };
        }
    }
}