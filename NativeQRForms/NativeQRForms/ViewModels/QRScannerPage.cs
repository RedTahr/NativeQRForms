using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeQRForms.ViewModels {
	public class QRScannerPageViewModel : ViewModelBase {
		public QRScannerPageViewModel(INavigationService navigationService)
			: base(navigationService) {
			Title = "QR Scanner Page";
		}
	}
}
