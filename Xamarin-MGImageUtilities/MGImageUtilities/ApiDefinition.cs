using System.Drawing;
using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MGImageUtilities {

	[Category, BaseType (typeof (UIImage))]
	public partial interface MGProportionalFill_UIImage {

		[Export ("imageToFitSize:method:")]
		UIImage ImageToFitSize (SizeF size, MGImageResizingMethod resizeMethod);

		[Export ("imageCroppedToFitSize:")]
		UIImage ImageCroppedToFitSize (SizeF size);

		[Export ("imageScaledToFitSize:")]
		UIImage ImageScaledToFitSize (SizeF size);
	}


	[Category, BaseType (typeof (UIImage))]
	public partial interface MGTint_UIImage {

		[Export ("imageTintedWithColor:")]
		UIImage ImageTintedWithColor (UIColor color);

		[Export ("imageTintedWithColor:fraction:")]
		UIImage ImageTintedWithColor (UIColor color, float fraction);
	}
}
