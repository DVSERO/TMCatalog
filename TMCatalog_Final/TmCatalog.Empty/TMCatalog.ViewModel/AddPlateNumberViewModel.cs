using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMCatalog.Common.MVVM;
using TMCatalogClient.Model;

namespace TMCatalog.ViewModel
{
  public class AddPlateNumberViewModel : ViewModelBase
  {
    public AddPlateNumberViewModel(VehicleType vehicleType)
    {
      this.SelectedVehicleType = vehicleType;

      NewVehicleTypePlateNr = new VehicleTypePlateNr
      {
        VehicleTypeId = this.SelectedVehicleType.Id
      };

      this.SavePlateNrCommand = new RelayCommand(this.SavePlateNrExecute, this.SavePlateNrCanExecute);
    }

    private bool SavePlateNrCanExecute()
    {
      return !string.IsNullOrWhiteSpace(this.NewVehicleTypePlateNr.PlateNr);
    }

    private void SavePlateNrExecute()
    {
      MainWindowViewModel.CatalogController.SavePlateNr(this.NewVehicleTypePlateNr);
      ViewService.CloseDialog(this);
    }

    private VehicleType selectedVehicleType;

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

    private VehicleTypePlateNr newVehicleTypePlateNr;

    public VehicleTypePlateNr NewVehicleTypePlateNr
    {
      get
      {
        return this.newVehicleTypePlateNr;
      }
      set
      {
        this.newVehicleTypePlateNr = value;
        this.RaisePropertyChanged();
      }
    }

    public RelayCommand SavePlateNrCommand { get; set; }
  }
}
