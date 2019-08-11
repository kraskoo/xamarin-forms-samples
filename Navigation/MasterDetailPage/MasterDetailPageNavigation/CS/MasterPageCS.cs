namespace MasterDetailPageNavigation
{
    using System.Collections.Generic;

    using Xamarin.Forms;

    public class MasterPageCs : ContentPage
    {
        public MasterPageCs()
        {
            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(
                new MasterPageItem
                    {
                        Title = "Contacts", IconSource = "contacts.png", TargetType = typeof(ContactsPageCs)
                    });
            masterPageItems.Add(
                new MasterPageItem
                    {
                        Title = "TodoList", IconSource = "todo.png", TargetType = typeof(TodoListPageCs)
                    });
            masterPageItems.Add(
                new MasterPageItem
                    {
                        Title = "Reminders", IconSource = "reminders.png", TargetType = typeof(ReminderPageCs)
                    });

            this.ListView = new ListView
                                {
                                    ItemsSource = masterPageItems,
                                    ItemTemplate = new DataTemplate(
                                        () =>
                                            {
                                                var grid = new Grid { Padding = new Thickness(5, 10) };
                                                grid.ColumnDefinitions.Add(
                                                    new ColumnDefinition { Width = new GridLength(30) });
                                                grid.ColumnDefinitions.Add(
                                                    new ColumnDefinition { Width = GridLength.Star });

                                                var image = new Image();
                                                image.SetBinding(Image.SourceProperty, "IconSource");
                                                var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                                                label.SetBinding(Label.TextProperty, "Title");

                                                grid.Children.Add(image);
                                                grid.Children.Add(label, 1, 0);

                                                return new ViewCell { View = grid };
                                            }),
                                    SeparatorVisibility = SeparatorVisibility.None
                                };

            this.IconImageSource = "hamburger.png";
            this.Title = "Personal Organiser";
            this.Padding = new Thickness(0, 40, 0, 0);
            this.Content = new StackLayout { Children = { this.ListView } };
        }

        public ListView ListView { get; }
    }
}