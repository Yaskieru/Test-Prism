using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using UIKit;
using Plugin.FacebookClient;

namespace TestPrism.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
            Xamarin.Calabash.Start();
#endif
            LoadApplication(new App(new iOSInitializer()));

            FacebookClientManager.Initialize(uiApplication, launchOptions);

            return base.FinishedLaunching(uiApplication, launchOptions);
        }

        [Export("applicationDidBecomeActive:")]
        public override void OnActivated(UIApplication uiApplication) => FacebookClientManager.OnActivated();

        [Export("application:openURL:options:")]
        public override bool OpenUrl(UIApplication app, NSUrl url, NSDictionary options) => FacebookClientManager.OpenUrl(app, url, options);

        [Export("application:openURL:sourceApplication:annotation:")]
        public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation) => FacebookClientManager.OpenUrl(application, url, sourceApplication, annotation);
    }
}
