using Foundation;
using UIKit;

namespace SWRevealViewControllerTest
{
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions) => true;
	}
}