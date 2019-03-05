using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMCatalog.Common.MVVM;
using TMCatalog.Model;

namespace TMCatalog.ViewModel
{
  public class OrderWindowViewModel : ViewModelBase
  {
    private List<Order> orders;
    private Order selectedOrder;

    public OrderWindowViewModel()
    {
      this.GetOrders();
    }

    public List<Order> Orders
    {
      get
      {
        return this.orders;
      }

      set
      {
        this.orders = value;
        this.RaisePropertyChanged();
      }
    }

    public Order SelectedOrder
    {
      get
      {
        return this.selectedOrder;
      }

      set
      {
        this.selectedOrder = value;
        this.RaisePropertyChanged();
      }
    }

    private void GetOrders()
    {
      this.Orders = MainWindowViewModel.CatalogController.GetAllOrders();

      if (this.Orders?.Count > 0)
      {
        this.SelectedOrder = this.Orders[0];
      }
    }
  }
}
