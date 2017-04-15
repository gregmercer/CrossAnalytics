using Android.App;
using Android.Widget;
using Android.OS;



namespace CrossAnalytics.Droid
{
    [Activity(Label = "CrossAnalytics", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ServiceLocator.Instance.Add<IMessage, MessageService>();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.test1Button);

            button.Click += delegate {

                IMessage message = ServiceLocator.Instance.Resolve<IMessage>();

                new AlertDialog.Builder(this)
                    .SetTitle("Hi There")
                    .SetMessage("You clicked Test1. Message: " + message.getMessage())
                    .SetPositiveButton("OK", delegate{})
                    .Show();
            };
        }
    }
}

