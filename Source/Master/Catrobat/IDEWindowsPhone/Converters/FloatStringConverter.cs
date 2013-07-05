﻿using System;
using System.Globalization;
using System.Windows.Data;
using Catrobat.Core.Misc.Helpers;

namespace Catrobat.IDEWindowsPhone.Converters
{
    public class FloatStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return FormatHelper.ConvertFloat((float) value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return FormatHelper.ParseFloat((string) value);
            }
            catch (Exception)
            {
                return parameter;
            }
        }
    }
}