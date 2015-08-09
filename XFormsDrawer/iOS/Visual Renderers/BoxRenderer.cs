using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFormsDrawer.iOS;
using System.ComponentModel;
using CoreGraphics;
using UIKit;


[assembly: ExportRenderer(typeof(BoxView), typeof(XFormsDrawer.iOS.BoxRenderer))]
namespace XFormsDrawer.iOS
{
	public class BoxRenderer : VisualElementRenderer<BoxView>
	{
		public BoxRenderer ()
		{
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == EllipseView.ColorProperty.PropertyName)
				this.SetNeedsDisplay(); // Force a call to Draw
		}

		public override void Draw(CGRect rect)
		{
			using (var context = UIGraphics.GetCurrentContext())
			{
//				var path = CGPath.EllipseFromRect(rect);
//				context.AddPath(path);
//				context.SetFillColor(this.Element.Color.ToCGColor());
//				context.DrawPath(CGPathDrawingMode.Fill);

				var path = new CGPath();
				path.AddRect (rect);
				context.SetFillColor (this.Element.FillColor);
				path.ad
			};
		}
	}
}

