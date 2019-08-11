namespace NavigationPageTitleView
{
    using System;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        private Page originalRoot;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigateCommand = new Command<Type>(async pageType => await this.NavigateToPage(pageType));
            this.BindingContext = this;
        }

        public ICommand NavigateCommand { get; }

        private async Task NavigateToPage(Type pageType)
        {
            Type[] types = { typeof(Command) };
            var info = pageType.GetConstructor(types);
            if (info != null)
            {
                var page = (Page)Activator.CreateInstance(pageType, new Command(this.RestoreOriginal));
                if (page is iOSExtendedTitleViewPage)
                {
                    page = new iOSNavigationPage(page);
                }
                else if (page is AndroidExtendedTitleViewPage)
                {
                    page = new AndroidNavigationPage(page);
                }

                this.SetRoot(page);
            }
            else
            {
                var page = (Page)Activator.CreateInstance(pageType);
                await this.Navigation.PushAsync(page);
            }
        }

        private void RestoreOriginal()
        {
            if (this.originalRoot == null)
            {
                return;
            }

            var app = Application.Current as App;
            app?.SetMainPage(this.originalRoot);
        }

        private void SetRoot(Page page)
        {
            var app = Application.Current as App;
            if (app == null)
            {
                return;
            }

            this.originalRoot = app.MainPage;
            app.SetMainPage(page);
        }
    }
}