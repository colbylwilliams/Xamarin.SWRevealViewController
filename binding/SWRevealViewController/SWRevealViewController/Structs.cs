using System;
using ObjCRuntime;

namespace Xamarin.SWRevealViewController
{
	[Native]
	public enum FrontViewPosition : long
	{
		LeftSideMostRemoved,
		LeftSideMost,
		LeftSide,
		Left,
		Right,
		RightMost,
		RightMostRemoved
	}

	[Native]
	public enum SWRevealToggleAnimationType : long
	{
		Spring,
		EaseOut
	}

	public enum SWRevealControllerOperation : uint
	{
		None,
		ReplaceRearController,
		ReplaceFrontController,
		ReplaceRightController
	}
}