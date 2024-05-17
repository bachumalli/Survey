using Foundation;
using UIKit;
using CoreGraphics;
using NativeLibrary;
namespace QualtricsSurvey.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register ("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate {
    
        [Export("window")]
        public UIWindow Window { get; set; }

        [Export ("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
        {
            Qualtrics.Shared.InitializeWithBrandId("bcbsla", "ZN_7ZFKkESfPMPpYbA", "SI_8rdDr3KjRIAfHQW", null);
            QualtricsViewController viewController =new QualtricsViewController();
           Qualtrics.Shared.DisplayInterceptFor("SI_8rdDr3KjRIAfHQW", viewController, null);
                // Override point for customization after application launch.
                                                                                                   // If not required for your application you can safely delete this method
                return true;
        }

        // UISceneSession Lifecycle

        [Export ("application:configurationForConnectingSceneSession:options:")]
        public UISceneConfiguration GetConfiguration (UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
        {
            // Called when a new scene session is being created.
            // Use this method to select a configuration to create the new scene with.
            return UISceneConfiguration.Create ("Default Configuration", connectingSceneSession.Role);
        }

        [Export ("application:didDiscardSceneSessions:")]
        public void DidDiscardSceneSessions (UIApplication application, NSSet<UISceneSession> sceneSessions)
        {
            // Called when the user discards a scene session.
            // If any sessions were discarded while the application was not running, this will be called shortly after `FinishedLaunching`.
            // Use this method to release any resources that were specific to the discarded scenes, as they will not return.
        }
    }

    public partial class QualtricsViewController : QualtricsSurveyViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var btn = UIButton.FromType(UIButtonType.System);
            btn.Frame = new CGRect(20, 200, 280, 44);
            btn.SetTitle("Click Me", UIControlState.Normal);

            var user = new UIViewController();

            btn.TouchUpInside += (sender, e) => {
                this.NavigationController.PushViewController(user, true);
            };
        }
    }

}


