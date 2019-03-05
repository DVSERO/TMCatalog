using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMCatalog.Common.MVVM;
using TMCatalogClient.Model;

namespace TMCatalog.ViewModel
{
  public class VehicleTypeViewModel : ViewModelBase
  {
    private VehicleType selectedVehicleType;
    private List<ProductGroup> vehicleTypeProducts;
    private object selectedProduct;
    private List<Article> articles;
    private Article selectedArticle;


    public VehicleTypeViewModel(VehicleType vehicleType)
    {
      this.SelectedVehicleType = vehicleType;

      if (this.SelectedVehicleType != null)
      {
        this.GetProductGroups();
      }

      this.CommandAddArticelToShoppingBasket = new RelayCommand(this.AddArticelToShoppingBasket, this.CanExecuteAddArticelToShoppingBasket);
    }

    public VehicleType SelectedVehicleType
    {
      get
      {
        return selectedVehicleType;
      }

      set
      {
        selectedVehicleType = value;
        this.RaisePropertyChanged();
      }
    }

    public List<ProductGroup> VehicleTypeProducts
    {
      get
      {
        return this.vehicleTypeProducts;
      }

      set
      {
        this.vehicleTypeProducts = value;
        this.RaisePropertyChanged();
      }
    }

    public object SelectedProduct
    {
      get
      {
        return this.selectedProduct;
      }

      set
      {
        this.selectedProduct = value;

        if (this.selectedProduct is Product)
        {
          this.GetArticles(this.selectedProduct as Product);
        }
        else
        {
          this.Articles = null;
        }

        this.RaisePropertyChanged();
      }
    }

    public List<Article> Articles
    {
      get
      {
        return this.articles;
      }

      set
      {
        this.articles = value;
        this.RaisePropertyChanged();
      }
    }

    public Article SelectedArticle
    {
      get
      {
        return this.selectedArticle;
      }

      set
      {
        this.selectedArticle = value;
        this.RaisePropertyChanged();
      }
    }

    public RelayCommand CommandAddArticelToShoppingBasket { get; set; }

    private void GetProductGroups()
    {
      this.VehicleTypeProducts = MainWindowViewModel.CatalogController.GetProdutGroups(this.SelectedVehicleType.Id);
    }

    private void GetArticles(Product product)
    {
      this.Articles = MainWindowViewModel.CatalogController.GetArticles(product.Id);
    }

    private void AddArticelToShoppingBasket()
    {
      MainWindowViewModel.Instance.AddArticelToShoppingBasket(this.SelectedArticle);
    }

    private bool CanExecuteAddArticelToShoppingBasket()
    {
      return this.SelectedArticle != null;
    }
  }
}
