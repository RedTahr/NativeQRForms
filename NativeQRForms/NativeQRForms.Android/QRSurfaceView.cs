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

namespace NativeQRForms.Droid {
	public class QRSurfaceView : SurfaceView {

		Android.Gms.Vision.Barcodes.BarcodeDetector detector;
		Android.Gms.Vision.CameraSource cameraSource;

		public QRSurfaceView(Context context) : base(context) {
			//https://firebase.google.com/docs/ml-kit/android/read-barcodes
			//FirebaseVisionImage image = FirebaseVisionImage.fromBitmap(bitmap);

			if(detector == null) {
				detector
					= new Android.Gms.Vision.Barcodes.BarcodeDetector
					.Builder(Application.Context).SetBarcodeFormats(Android.Gms.Vision.Barcodes.BarcodeFormat.QrCode)
					.Build();

				if(!detector.IsOperational) {
					System.Diagnostics.Debug.WriteLine("android barcode detector is not operational");
					return;
				}

				if(cameraSource == null) {
					cameraSource = new Android.Gms.Vision.CameraSource.Builder(Application.Context, detector).Build();
				}
			}
			
		}
	}
}