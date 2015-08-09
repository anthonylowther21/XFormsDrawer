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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XFormsDrawer;
using XFormsDrawer.Droid;
using Android.Graphics;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(EllipseView), typeof(EllipseRenderer))]
namespace XFormsDrawer.Droid
{
	public class EllipseRenderer : VisualElementRenderer<EllipseView>
	{
		public EllipseRenderer()
		{
			this.SetWillNotDraw(false);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == EllipseView.ColorProperty.PropertyName)
				this.Invalidate(); // Force a call to OnDraw
		}

		protected override void OnDraw(Canvas canvas)
		{
			var element = this.Element;
			var rect = new Rect();
			this.GetDrawingRect(rect);

			var paint = new Paint()
			{
				Color = element.Color.ToAndroid(),
				AntiAlias = true
			};

			canvas.DrawOval(new RectF(rect), paint);
		}
	}
}