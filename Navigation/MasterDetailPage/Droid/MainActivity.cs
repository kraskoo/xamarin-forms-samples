namespace MasterDetailPageNavigation.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;

    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    [Activity(
        Label = "MasterDetailPageNavigation.Droid",
        Icon = "@drawable/icon",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            this.LoadApplication(new App());
        }
    }
}