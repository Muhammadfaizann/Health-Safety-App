using System;
using UIKit;

namespace HealthSafetyApp.iOS
{
    public class SplashViewController : UIViewController
    {
        public SplashViewController() : base() { }


        /*public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var viewAnimation = LOTAnimationView.AnimationNamed("3583-yoga-girl-3");
            viewAnimation.ContentMode = UIViewContentMode.Center;

            View.AddSubview(viewAnimation);

            //View.BackgroundColor = UIColor.SystemTealColor;

            //center the animation 
            viewAnimation.Center = View.Center;

            viewAnimation.PlayWithCompletion((finished) =>
            {
                UIApplication.SharedApplication.Delegate.FinishedLaunching
                (UIApplication.SharedApplication, new Foundation.NSDictionary());
            });

        }*/

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }
    }
}
