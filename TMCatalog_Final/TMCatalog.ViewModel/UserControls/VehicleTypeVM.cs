using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMCatalog.Common.Model;
using TMCatalog.Common.MVVM;
using TMCatalog.Common.TMCatalogContentTypes;
using TMCatalog.Logic;
using TMCatalogClient.Model;

namespace TMCatalog.ViewModel.UserControls
{
  public class VehicleTypeVM : ViewModelBase, IVehicleTypeContent
  {
    private List<Product> vehicleTypeProducts;

    public VehicleTypeVM(IVehicleType vehicleType)
    {
      this.VehicleType = vehicleType;
            Task.Run(() => this.VehicleTypeProducts = Data.Catalog.GetVehicleTypeProducts(VehicleType.Id));
    }

    public string Header => $"{this.VehicleType.Description}";    

    public IVehicleType VehicleType { get; set; }

    public List<Product> VehicleTypeProducts
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

    public void Init()
    {
      //Task.Run(() => this.VehicleTypeProducts = Data.Catalog.GetVehicleTypeProducts(VehicleType.Id));
    }
  }
}
