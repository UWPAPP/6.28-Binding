using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace _6._28_Binding
{
    class BookConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, string language)
        {
            if (parameter.Equals("Author"))
            {
                return "作者:" + value;
            }
            else if (parameter.Equals("Title")) {
                return "书名:" + value;
            }
            return value;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return false;
        }
    }
}
