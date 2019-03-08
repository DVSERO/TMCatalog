using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TMCatalog.Common.TMCatalogContentTypes;

namespace TMCatalog.View.TemplateSelectors
{
  public class TMCatalogContentSelector : DataTemplateSelector
  {
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
      if (item is IVehicleSearchContent)
      {
        return Application.Current.MainWindow.TryFindResource("VehicleSearchTemplate") as DataTemplate;
      }
      else if (item is IVehicleTypeContent)
      {
        return Application.Current.MainWindow.TryFindResource("VehicleTypeTemplate") as DataTemplate;
      }
      return null;
    }
  }
}
