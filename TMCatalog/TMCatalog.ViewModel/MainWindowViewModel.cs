// ------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalog.ViewModel
{
    using TMCatalog.Common.MVVM;
    using TMCatalog.Logic;
    using TMCatalog.ViewModel.UserControls;

    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
            this.VehicleSearchViewModel = new VehicleSearchViewModel();
        }

        public RelayCommand CloseCommand { get; set; }

        public void CloseCommandExecute()
        {
            ViewService.CloseDialog(this);
        }

        private VehicleSearchViewModel vehicleSearchViewModel;

        public VehicleSearchViewModel VehicleSearchViewModel
        {
            get
            {
                return this.vehicleSearchViewModel;
            }

            set
            {
                this.vehicleSearchViewModel = value;
                this.RaisePropertyChanged();
            }
        }

    }
}
