using System;
using Xamarin.Forms;

namespace XFormsDrawer
{
	public class BoxView : View
	{
		public static readonly BindableProperty BorderColorProperty =
			BindableProperty.Create<EllipseView, Color>(p => p.Color, Color.Accent);

		public static readonly BindableProperty FillColorProperty =
			BindableProperty.Create<EllipseView, Color>(p => p.Color, Color.Accent);


		public BoxView ()
		{
		}

		public Color BorderColor
		{
			get { return (Color)GetValue(BorderColorProperty); }
			set { SetValue(BorderColorProperty, value); }
		}

		public Color FillColor
		{
			get { return (Color)GetValue(FillColorProperty); }
			set { SetValue(FillColorProperty, value); }
		}
	}
}

