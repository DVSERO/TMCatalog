using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMCatalog.Common.MVVM;
using TMCatalog.Common.TMCatalogContentTypes;
using TMCatalog.Logic;
using TMCatalogClient.Model;

namespace TMCatalog.ViewModel.UserControls
{
  public class VehicleSearchVM : ViewModelBase, IVehicleSearchContent
  {
    private List<Manufacturer> manufacturers;

    private List<TMCatalogClient.Model.Model> models;

    private List<VehicleType> vehicleList;

    private VehicleType selectedVehicleType;

    private int manufacturerId;

    private int modelId;

    public VehicleSearchVM()
    {
      Task.Run(() =>
      {
        Manufacturers = Data.Catalog.GetManufacturers();
      });

      OpenVehicleCommand = new RelayCommand(() => MainWindowViewModel.Instance.OpenVehicle(this.SelectedVehicleType));
    }

    public int ManufacturerId
    {
      get
      {
        return manufacturerId;
      }

      set
      {
        manufacturerId = value;
        this.RaisePropertyChanged();

        Task.Run(() =>
        {
          VehicleList = new List<VehicleType>();
          Models = Data.Catalog.GetModels(manufacturerId);
        });
      }
    }

    public int ModelId
    {
      get
      {
        return modelId;
      }

      set
      {
        modelId = value;
        this.RaisePropertyChanged();

        VehicleList = Data.Catalog.GetVehicleTypes(modelId);
      }
    }

    public List<Manufacturer> Manufacturers
    {
      get
      {
        return manufacturers;
      }

      set
      {
        manufacturers = value;
        this.RaisePropertyChanged();
      }
    }

    public List<TMCatalogClient.Model.Model> Models
    {
      get
      {
        return models;
      }

      set
      {
        models = value;
        this.RaisePropertyChanged();
      }
    }

    public List<VehicleType> VehicleList
    {
      get
      {
        return vehicleList;
      }

      set
      {
        vehicleList = value;
        this.RaisePropertyChanged();
      }
    }

    public VehicleType SelectedVehicleType
    {
      get
      {
        return this.selectedVehicleType;
      }

      set
      {
        this.selectedVehicleType = value;
        this.RaisePropertyChanged();
      }
    }

    public string Header => "Vehicle search";    

    public RelayCommand OpenVehicleCommand { get; set; }

    public void Init()
    {
    }
  }
}
