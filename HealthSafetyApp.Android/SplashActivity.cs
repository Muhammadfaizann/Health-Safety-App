using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthSafetyApp.Droid
{
    [Activity(Theme = "@style/MainTheme", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        //ValueAnimator animator;
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);

            SetContentView(Resource.Drawable.splash_Centered);
            System.Threading.ThreadPool.QueueUserWorkItem(o => LoadActivity());
            global::Xamarin.Forms.Forms.Init(this, bundle);
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            ImageView imageView = FindViewById<ImageView>(Resource.Id.animated_loading);

            Android.Graphics.Drawables.AnimationDrawable animation = (Android.Graphics.Drawables.AnimationDrawable)imageView.Drawable;
            animation.Start();
            //animator.RepeatCount = 1;
            //animator.SetDuration(10000);
            //animator.Start();

        }

        private void LoadActivity()
        {
            System.Threading.Thread.Sleep(5000); // Simulate a long pause    
            RunOnUiThread(() => StartActivity(typeof(MainActivity)));
            //StartActivity(typeof(MainActivity));
        }

        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Create your application here
        //    StartActivity(typeof(MainActivity));
        //}

    }
}