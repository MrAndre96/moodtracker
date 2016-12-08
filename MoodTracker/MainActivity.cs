using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace MoodTracker
{
    [Activity(Label = "MoodTracker", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button btn_Login = FindViewById<Button>(Resource.Id.btn_Login);
            btn_Login.Click += Button_Click;
        }
        private void Button_Click(object sender, System.EventArgs e)
        {
            Button btn_Login = FindViewById<Button>(Resource.Id.btn_Login);
            var intent = new Intent(this, typeof(Registration));
            StartActivity(intent);
        }
        private void Registration_Click(object sender, System.EventArgs e)
        {
            TextView but = FindViewById<Button>(Resource.Id.tv_Register);
            but.Text = "koffer";
        }
    }
}

