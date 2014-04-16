using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Hello_World_iPhone
{
	public partial class Hello_World_iPhoneViewController : UIViewController
	{
		protected int numberOfTimesClicked = 0;

		public Hello_World_iPhoneViewController(IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		partial void actionButtonClick (NSObject sender)
		{
			this.lblOutput.Text = "Button \"" +  ((UIButton) sender).CurrentTitle + "\" clicked.";
		}

		#region View lifecycle

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.
			this.btnClickMe.TouchUpInside += (sender, eventArgs) => {
				this.numberOfTimesClicked++;
				this.lblOutput.Text = "Clicked " + this.numberOfTimesClicked.ToString() + " times";
			};
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
		}

		public override void ViewDidDisappear(bool animated)
		{
			base.ViewDidDisappear(animated);
		}

		#endregion
	}
}

