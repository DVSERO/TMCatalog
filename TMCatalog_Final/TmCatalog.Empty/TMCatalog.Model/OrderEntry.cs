using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TMCatalog.Common.MVVM;
using TMCatalogClient.Model;

namespace TMCatalog.Model
{
  public class OrderEntry : ViewModelBase
  {
    private int quantity;

    [Key]
    public int ID { get; set; }
    /// <summary>
    /// Gets or sets the article id
    /// </summary>
    public int ArticleId { get; set; }

    /// <summary>
    /// Gets or sets the article
    /// </summary>
    public Article Article { get; set; }

    /// <summary>
    /// Gets or sets the quantity
    /// </summary>
    public int Quantity
    {
      get
      {
        return this.quantity;
      }

      set
      {
        this.quantity = value;
        this.RaisePropertyChanged();
        this.RaisePropertyChanged(nameof(this.Price));
      }
    }

    public string OrderID { get; set; }

    public Order Order { get; set; }

    [NotMapped]
    /// <summary>
    /// Gets or sets the price
    /// </summary>
    public decimal Price => this.Quantity * this.UnitPrice;

    /// <summary>
    /// Gets or sets the price
    /// </summary>
    public decimal UnitPrice { get; set; }
  }
}
