using System;
using HealthSafetyApp.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Button), typeof(MyButtonRenderer))]
namespace HealthSafetyApp.iOS.Renderers
{
        public class MyButtonRenderer : ButtonRenderer
        {
            public override void LayoutSubviews()
            {
                base.LayoutSubviews();
                if (Element.ContentLayout.Position == Button.ButtonContentLayout.ImagePosition.Left)
                {
                    const int imageMargin = 20; // This might need to get multiplied by the screen density, not sure yet.  I'll update this later if it does.
                    nfloat imageOffset = Control.ImageView.Frame.Left - imageMargin;
                    Control.ImageEdgeInsets = new UIEdgeInsets(0, -imageOffset, 0, imageOffset);

                    nfloat imageWidth = Control.ImageView.Frame.Width + imageMargin;
                    nfloat textOffset = Control.TitleLabel.Frame.Left - (imageWidth + Control.Frame.Width - Control.TitleLabel.Frame.Width) / 2;
                    Control.TitleEdgeInsets = new UIEdgeInsets(0, -textOffset, 0, textOffset);
                }
            }
        }
    
}
