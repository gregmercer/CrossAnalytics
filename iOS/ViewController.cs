using System;

using UIKit;
using Mono.Security.Interface;

namespace CrossAnalytics.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Test1.TouchUpInside += delegate
            {
                IMessage message = ServiceLocator.Instance.Resolve<IMessage>();

                var alert = UIAlertController.Create(
                    "Hi There", 
                    "You clicked Test1. Message: " + message.getMessage(),
                    UIAlertControllerStyle.Alert
                );

                alert.AddAction (UIAlertAction.Create("Ok", UIAlertActionStyle.Cancel, null));
                PresentViewController (alert, animated: true, completionHandler: null);
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.        
        }
    }
}
