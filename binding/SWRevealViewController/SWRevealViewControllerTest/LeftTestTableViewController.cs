using System;

namespace SWRevealViewControllerTest
{
	public partial class LeftTestTableViewController : TestTableViewController
	{
		public LeftTestTableViewController (IntPtr handle) : base (handle) { }

		public override string ReuseId => "LeftTestTableViewCell";
	}
}