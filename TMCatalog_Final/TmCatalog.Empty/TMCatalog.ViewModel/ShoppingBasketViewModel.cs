using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMCatalog.Common.Enums;
using TMCatalog.Common.MVVM;
using TMCatalog.Model;
using TMCatalogClient.Model;

namespace TMCatalog.ViewModel
{
  public class ShoppingBasketViewModel : ViewModelBase
  {
    private Order order;
    private OrderEntry selectedOrderEntry;

    public ShoppingBasketViewModel()
    {
      this.Order = MainWindowViewModel.CatalogController.GetOpenOrder();
      if (Order == null)
      {
        Order = new Order
        {
          Description = "Rendeles",
          ID = Guid.NewGuid().ToString(),
          OrderEntries = new ObservableCollection<OrderEntry>(),
          OrderState = EOrderState.Open
        };
      }

      this.Order.RefreshTotalPrice();

      this.CommandIncreaseStock = new RelayCommand(this.IncreaseStock, CanExecuteStockOperation);
      this.CommandDecreaseStock = new RelayCommand(this.DecreaseStock, CanExecuteStockOperation);
      this.CommandSaveShoppingBasket = new RelayCommand(this.SaveOrder, this.CanExecuteSaveShoppingBasket);
      this.CommandCloseOrder = new RelayCommand(this.CloseOrder, this.CanExecuteCloseOrder);
      this.CommandOpenOrders = new RelayCommand(this.OpenOrderWindow);
    }

    public Order Order
    {
      get
      {
        return this.order;
      }
      set
      {
        this.order = value;
        this.RaisePropertyChanged();
      }
    }

    public OrderEntry SelectedOrderEntry
    {
      get
      {
        return selectedOrderEntry;
      }

      set
      {
        this.selectedOrderEntry = value;
        this.RaisePropertyChanged();
      }
    }

    public RelayCommand CommandIncreaseStock { get; set; }

    public RelayCommand CommandDecreaseStock { get; set; }

    public RelayCommand CommandSaveShoppingBasket { get; set; }

    public RelayCommand CommandCloseOrder { get; set; }

    public RelayCommand CommandOpenOrders { get; set; }

    public void AddToShoppingBasket(Article article)
    {
      OrderEntry orderEntry = this.Order.OrderEntries.FirstOrDefault(a => a.ArticleId == article.Id);

      if (orderEntry != null)
      {
        orderEntry.Quantity++;
      }
      else
      {
        orderEntry = new OrderEntry
        {
          Article = article,
          ArticleId = article.Id,
          UnitPrice = MainWindowViewModel.CatalogController.GetArticlePrice(article.Id),
          Quantity = 1,
        };

        this.Order.OrderEntries.Add(orderEntry);
      }


      this.Order.RefreshTotalPrice();
    }

    private void IncreaseStock()
    {
      if (this.SelectedOrderEntry.Quantity < 100)
      {
        this.SelectedOrderEntry.Quantity++;
        this.Order.RefreshTotalPrice();
      }
    }

    private void DecreaseStock()
    {
      this.SelectedOrderEntry.Quantity--;

      if (this.SelectedOrderEntry.Quantity == 0)
      {
        this.Order.OrderEntries.Remove(this.SelectedOrderEntry);
      }

      this.Order.RefreshTotalPrice();
    }

    private bool CanExecuteStockOperation()
    {
      return this.SelectedOrderEntry != null;
    }

    private void SaveOrder()
    {
      MainWindowViewModel.CatalogController.SetOrder(this.Order);
    }

    private bool CanExecuteSaveShoppingBasket()
    {
      return this.Order != null;
    }

    private void CloseOrder()
    {
      this.SaveOrder();
      MainWindowViewModel.CatalogController.CloseOrder(this.Order.ID);

      this.Order = new Order
      {
        Description = "Rendeles",
        ID = Guid.NewGuid().ToString(),
        OrderEntries = new ObservableCollection<OrderEntry>(),
        OrderState = EOrderState.Open
      };
    }

    private bool CanExecuteCloseOrder()
    {
      return this.Order?.OrderState == EOrderState.Open;
    }

    private void OpenOrderWindow()
    {
      ViewService.ShowDialog(new OrderWindowViewModel(), MainWindowViewModel.Instance);
    }
  }
}
