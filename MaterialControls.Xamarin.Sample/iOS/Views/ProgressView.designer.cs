// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
    [Register ("ProgressView")]
    partial class ProgressView
    {
        [Outlet]
        MaterialControls.MDProgress CircularProgress { get; set; }


        [Outlet]
        MaterialControls.MDProgress LinearProgress { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CircularProgress != null) {
                CircularProgress.Dispose ();
                CircularProgress = null;
            }

            if (LinearProgress != null) {
                LinearProgress.Dispose ();
                LinearProgress = null;
            }
        }
    }
}