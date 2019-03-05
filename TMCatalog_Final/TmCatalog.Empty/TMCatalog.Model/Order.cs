using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TMCatalog.Common.Enums;
using TMCatalog.Common.MVVM;

namespace TMCatalog.Model
{
  public class Order : ViewModelBase
  {
    private ObservableCollection<OrderEntry> orderEntries;
    private string description;

    [Key]
    public string ID { get; set; }

    public string Description
    {
      get
      {
        return this.description;
      }

      set
      {
        this.description = value;
        this.RaisePropertyChanged();
      }
    }

    public EOrderState OrderState { get; set; }

    public ObservableCollection<OrderEntry> OrderEntries
    {
      get
      {
        return this.orderEntries;
      }
      set
      {
        this.orderEntries = value;
        this.RaisePropertyChanged();
      }
    }

    [NotMapped]
    public decimal TotalPrice
    {
      get
      {
        if (this.OrderEntries?.Count > 0)
        {
          return this.OrderEntries.Sum(o => o.Price);
        }

        return 0;
      }
    }

    public void RefreshTotalPrice()
    {
      this.RaisePropertyChanged(nameof(this.TotalPrice));
    }
  }
}
