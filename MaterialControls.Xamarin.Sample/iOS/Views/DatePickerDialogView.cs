
using System;

using Foundation;
using UIKit;
using MaterialControls;
using MaterialControls.Xamarin.Sample.Core.ViewModels;

namespace MaterialControls.Xamarin.Sample.iOS.Views
{
	public partial class DatePickerDialogView : BaseView<DatePickerDialogViewModel>
	{
		MDDatePickerDialog pickerDialog;
		public DatePickerDialogView () : base ("DatePickerDialogView", null)
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
		}

		partial void ButtonPressed (NSObject sender)
		{
			if(pickerDialog ==null) {
				pickerDialog = new MDDatePickerDialog();
				pickerDialog.Delegate = new DatePickerDialogDelegate(TextField);
			}
			pickerDialog.Calendar.OverrideSelectedCellColor(UIColor.Red);
			pickerDialog.MaximumDate = ConvertDateTimeToNSDate(new DateTime(2019,1,1));
			pickerDialog.CloseWhenClickBackground = true;
			pickerDialog.Show();
		}

		public DateTime ConvertNSDateToDateTime(NSDate date)
		{
			DateTime newDate = TimeZone.CurrentTimeZone.ToUniversalTime(new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
			return newDate.AddSeconds(date.SecondsSinceReferenceDate).ToLocalTime();
		}

		public NSDate ConvertDateTimeToNSDate(DateTime date)
		{
			DateTime newDate = TimeZone.CurrentTimeZone.ToLocalTime(
				new DateTime(2001, 1, 1, 0, 0, 0));
			return NSDate.FromTimeIntervalSinceReferenceDate(
				(date - newDate).TotalSeconds);
		}
	}

	public class DatePickerDialogDelegate:MDDatePickerDialogDelegate {
		UITextField TextField;
		NSDateFormatter DateFormater;

		public DatePickerDialogDelegate (UITextField textField){
			TextField = textField;
			DateFormater = new NSDateFormatter();
			DateFormater.DateFormat = "dd-MM-yyyy";
		}

		#region implemented abstract members of MDCalendarDatePickerDialogDelegate
		public override void DatePickerDialogDidSelectDate (NSDate date)
		{
			TextField.Text = DateFormater.StringFor(date);
		}
		#endregion
	}
}

