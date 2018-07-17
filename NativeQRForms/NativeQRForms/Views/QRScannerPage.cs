using NativeQRForms.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NativeQRForms.Views {
	public class QRScannerPage : ContentPage {

		private QRScannerView qrScannerView;

		public QRScannerPage() {
			Title = "QR Scanner";
			qrScannerView = new QRScannerView {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
			};

			var grid = new Grid {
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
			};

			grid.Children.Add(qrScannerView);

			// The root page of your application
			Content = grid;
		}
	}
}
