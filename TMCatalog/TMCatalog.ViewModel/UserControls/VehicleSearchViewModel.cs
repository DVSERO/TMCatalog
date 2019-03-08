
namespace TMCatalog.ViewModel.UserControls
{
    using System.Collections.Generic;
    using TMCatalog.Common.MVVM;
    using TMCatalog.Logic;
    using TMCatalogClient.Model;

    public class VehicleSearchViewModel : ViewModelBase
    {
        public VehicleSearchViewModel()
        {
            this.Manufacturers = Data.Catalog.GetManufacturers();
        }

        private List<Manufacturer> manufacturers;

        public List<Manufacturer> Manufacturers
        {
            get
            {
                return this.manufacturers;
            }

            set
            {
                this.manufacturers = value;
                this.RaisePropertyChanged();
            }
        }

    }


}
