namespace MasterDetailPageNavigation
{
    using Xamarin.Forms;

    public class TodoListPageCs : ContentPage
    {
        public TodoListPageCs()
        {
            this.Title = "TodoList Page";
            this.Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "Todo list data goes here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}