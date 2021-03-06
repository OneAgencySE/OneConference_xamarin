﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Foundation;
using UIKit;

namespace OneConference.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Calabash.Start();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            AppCenter.Start("7640169e-63e0-464c-9df3-016f6a370069", typeof(Analytics), typeof(Crashes));

            return base.FinishedLaunching(app, options);
        }
    }
}
