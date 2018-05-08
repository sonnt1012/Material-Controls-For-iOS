using CoreGraphics;
using MaterialControls.Xamarin.Sample.Core.ViewModels;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	public partial class SliderView : BaseView<SliderViewModel>
	{
		public SliderView () : base ("SliderView", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			continuousSlider.ValueLabelMode = MDSliderValueLabelMode.Always;
			discreteSlider.MinimumValue = 1.0f;
			discreteSlider.MaximumValue = 10.0f;
			discreteSlider.Step = 1.0f;
			discreteSlider.Value = 4.0f;

			var newSlider = new MDSlider(CGRect.Empty)
			{
				TranslatesAutoresizingMaskIntoConstraints = false,
				MinimumValue = 1.0f,
				Step = 1.0f,
				MaximumValue = 10.0f,
				IsTickMarksVisible = true,
				IsThumbVisibleOnFocused = true,
				ValueLabelMode = MDSliderValueLabelMode.Always
			};
			View.Add(newSlider);
			newSlider.LeadingAnchor.ConstraintEqualTo(View.LayoutMarginsGuide.LeadingAnchor, 40).Active = true;
			newSlider.TrailingAnchor.ConstraintEqualTo(View.LayoutMarginsGuide.TrailingAnchor, -20).Active = true;
			newSlider.BottomAnchor.ConstraintEqualTo(View.LayoutMarginsGuide.BottomAnchor, -40).Active = true;
		}
	}
}

