using System;
using System.Windows.Data;
using System.IO;
using System.Windows.Media.Imaging;

namespace LOLVideo.Helper
{
    public class BytesToBitmapConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            Stream imageData = new MemoryStream((byte[])value);
            imageData.Seek(0, SeekOrigin.Begin);
            BitmapImage tempImage = new BitmapImage();
            tempImage.BeginInit();
            tempImage.StreamSource = imageData;
            tempImage.EndInit();
            return tempImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
