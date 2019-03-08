using System;
using System.Globalization;
using System.Windows.Data;
using TMCatalog.Common.Enums;

namespace TMCatalog.Common.Converters
{
  public class OrderStateConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is EOrderState)
      {
        EOrderState state = (EOrderState)value;

        switch (state)
        {
          case EOrderState.Open:
            return "Megnyitva";

          case EOrderState.Closed:
            return "Zarva";
        }
      }

      return null;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return null;
    }
  }
}
