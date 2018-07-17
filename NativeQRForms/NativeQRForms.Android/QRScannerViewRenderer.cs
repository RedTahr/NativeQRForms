using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NativeQRForms;

[assembly: Xamarin.Forms.ExportRenderer(typeof(NativeQRForms.Controls.QRScannerView), typeof(NativeQRForms.Droid.QRScannerViewRenderer))]
namespace NativeQRForms.Droid {
	public class QRScannerViewRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<NativeQRForms.Controls.QRScannerView, QRSurfaceView> {
	}
}