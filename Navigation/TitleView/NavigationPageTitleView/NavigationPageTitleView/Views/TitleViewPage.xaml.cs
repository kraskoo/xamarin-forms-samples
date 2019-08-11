namespace NavigationPageTitleView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Xamarin.Forms;

    public partial class TitleViewPage : ContentPage
    {
        private readonly List<View> views;
        private int index;

        public TitleViewPage()
        {
            this.InitializeComponent();

            this.views = new List<View>
                              {
                                  new SearchBar { HeightRequest = 44, WidthRequest = 300 },
                                  new ActivityIndicator { IsRunning = true },
                                  new BoxView { BackgroundColor = Color.Red },
                                  new Button { Text = "Save" },
                                  new DatePicker(),
                                  new Editor { Placeholder = "Enter text in Editor", WidthRequest = 300 },
                                  new Entry { Placeholder = "Enter text in Entry", WidthRequest = 300 },
                                  new Image { Source = "coffee.png", HeightRequest = 44 },
                                  new Label { Text = "Label text" },
                                  new Picker
                                      {
                                          ItemsSource = Enumerable.Range(0, 10).Select(i => $"Item {i}").ToList(),
                                          Title = "Picker",
                                          WidthRequest = 300
                                      },
                                  new ProgressBar { Progress = .5, WidthRequest = 300 },
                                  new Slider { WidthRequest = 300 },
                                  new Stepper(),
                                  new Switch(),
                                  new TimePicker()
                              };
        }

        private View CreateTitleView(View view)
        {
            view.HorizontalOptions = LayoutOptions.Fill;
            view.VerticalOptions = LayoutOptions.CenterAndExpand;

            var titleView = new StackLayout { Children = { view }, Margin = new Thickness(15, 0) };
            return titleView;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            NavigationPage.SetTitleView(this, this.CreateTitleView(this.views[this.index++]));
            if (this.index >= this.views.Count)
            {
                this.index = 0;
            }
        }
    }
}