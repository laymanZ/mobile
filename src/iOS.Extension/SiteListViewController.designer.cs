// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Bit.iOS.Extension
{
	[Register ("SiteListViewController")]
	partial class SiteListViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem AddBarButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem CancelBarButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UINavigationItem NavItem { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView TableView { get; set; }

		[Action ("AddBarButton_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void AddBarButton_Activated (UIBarButtonItem sender);

		[Action ("CancelBarButton_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CancelBarButton_Activated (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (AddBarButton != null) {
				AddBarButton.Dispose ();
				AddBarButton = null;
			}
			if (CancelBarButton != null) {
				CancelBarButton.Dispose ();
				CancelBarButton = null;
			}
			if (NavItem != null) {
				NavItem.Dispose ();
				NavItem = null;
			}
			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}
		}
	}
}
