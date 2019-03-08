using System;
using System.Collections.Generic;
using TMCatalog.Common.MVVM;
using TMCatalogClient.Model;

namespace TMCatalog.ViewModel
{
  public class VehicleSelection : ViewModelBase
  {
    private int manufacturerID;

    private int modelID;

    private List<Manufacturer> manufactureList;

    private List<TMCatalogClient.Model.Model> modelList;

    private List<VehicleType> vehicleTypeList;

    private VehicleType selectedVehicleType;

    public VehicleSelection()
    {
      this.OpenVehicleCommand = new RelayCommand(this.OpenVehicleExecute);
      this.GetManufacturers();
      this.CommandAddPlateNumber = new RelayCommand(this.OpenAddPlateNumberWindow, this.CanExecuteOpenAddPlateNumberWindow);
    }

    public int ManufactureID
    {
      get
      {
        return this.manufacturerID;
      }

      set
      {
        this.manufacturerID = value;
        this.GetModels(this.manufacturerID);
        this.RaisePropertyChanged();
      }
    }

    public int ModelID
    {
      get
      {
        return this.modelID;
      }

      set
      {
        this.modelID = value;
        this.GetVehicleTypes(this.modelID);
        this.RaisePropertyChanged();
      }
    }

    public List<Manufacturer> ManufactureList
    {
      get
      {
        return this.manufactureList;
      }

      set
      {
        this.manufactureList = value;
        this.RaisePropertyChanged();
      }
    }

    public List<TMCatalogClient.Model.Model> ModelList
    {
      get
      {
        return this.modelList;
      }

      set
      {
        this.modelList = value;
        this.RaisePropertyChanged();
      }
    }

    public List<VehicleType> VehicleTypeList
    {
      get
      {
        return this.vehicleTypeList;
      }

      set
      {
        this.vehicleTypeList = value;
        this.RaisePropertyChanged();
      }
    }

    public RelayCommand OpenVehicleCommand { get; set; }

    public RelayCommand CommandAddPlateNumber { get; set; }

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


    private void GetManufacturers()
    {
      this.ManufactureList = MainWindowViewModel.CatalogController.GetManufacturers();
    }

    private void GetModels(int manufacturerID)
    {
      this.ModelList?.Clear();
      this.ModelList = MainWindowViewModel.CatalogController.GetModels(manufacturerID);
    }

    private void GetVehicleTypes(int modelID)
    {
      this.VehicleTypeList?.Clear();
      this.VehicleTypeList = MainWindowViewModel.CatalogController.GetVehicleType(modelID);
    }

    private void OpenVehicleExecute()
    {
      if (this.SelectedVehicleType != null)
      {
        MainWindowViewModel.Instance?.ChangeVehicleSelection(this.SelectedVehicleType);
      }
    }

    private void OpenAddPlateNumberWindow()
    {
      ViewService.ShowDialog(new AddPlateNumberViewModel(this.SelectedVehicleType), 
        MainWindowViewModel.Instance);
    }

    private bool CanExecuteOpenAddPlateNumberWindow()
    {
      return this.SelectedVehicleType != null;
    }
  }
}
