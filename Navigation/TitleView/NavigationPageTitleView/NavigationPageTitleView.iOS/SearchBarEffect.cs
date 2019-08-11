using NavigationPageTitleView.iOS;

using Xamarin.Forms;

[assembly: ResolutionGroupName("XamarinDocs")]
[assembly: ExportEffect(typeof(SearchBarEffect), "SearchBarEffect")]

namespace NavigationPageTitleView.iOS
{
    using UIKit;

    using Xamarin.Forms.Platform.iOS;

    public class SearchBarEffect : PlatformEffect
    {
        private UIColor _defaultBackColor;

        private UIImage _defaultBackImage;

        private UIColor _defaultTintColor;

        protected override void OnAttached()
        {
            if (this._defaultBackColor == null)
            {
                this._defaultBackColor = this.Control.BackgroundColor;
            }

            this.Control.BackgroundColor = Color.Cornsilk.ToUIColor();

            if (this.Control is UISearchBar searchBar)
            {
                if (this._defaultTintColor == null)
                {
                    this._defaultTintColor = searchBar.BarTintColor;
                }

                if (this._defaultBackImage == null)
                {
                    this._defaultBackImage = searchBar.BackgroundImage;
                }

                searchBar.BarTintColor = Color.Cornsilk.ToUIColor();
                searchBar.BackgroundImage = new UIImage();
            }
        }

        protected override void OnDetached()
        {
            this.Control.BackgroundColor = this._defaultBackColor;
            if (this.Control is UISearchBar searchBar)
            {
                searchBar.BarTintColor = this._defaultTintColor;
                searchBar.BackgroundImage = this._defaultBackImage;
            }
        }
    }
}