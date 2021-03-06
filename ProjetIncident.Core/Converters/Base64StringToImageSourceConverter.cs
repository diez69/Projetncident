﻿using System;
using System.Globalization;
using System.IO;
using Xamarin.Forms;

namespace ProjetIncident.Core.Converters
{
    public class Base64StringToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                var base64String = value as string;
                byte[] imgBytes = null;
                if (string.IsNullOrEmpty(base64String))
                    imgBytes = new byte[] { };
                else
                    imgBytes = System.Convert.FromBase64String(base64String);
                return ImageSource.FromStream(() => new MemoryStream(imgBytes));
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
