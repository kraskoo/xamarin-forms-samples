﻿namespace TabbedPageWithNavigationPage.iOS
{
    using Foundation;

    using UIKit;

    using Xamarin.Forms;
    using Xamarin.Forms.Platform.iOS;

    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            this.LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}