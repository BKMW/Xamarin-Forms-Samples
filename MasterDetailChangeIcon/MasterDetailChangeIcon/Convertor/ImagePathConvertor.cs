﻿using System;
using Xamarin.Forms;

namespace MasterDetailChangeIcon
{
	public class ImagePathConvertor : IValueConverter
	{
		public ImagePathConvertor()
		{
		}

		#region IValueConverter implementation

		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value is bool)  {

				if((bool)value == true)
					return "noci.png";
				else
					return "icon.png";
			}
			return "";
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

