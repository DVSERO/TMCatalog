using TMCatalog.Common.Model;

namespace TMCatalog.Common.TMCatalogContentTypes
{
  public interface IVehicleTypeContent : ITMCatalogContent
  {
    IVehicleType SelectedVehicleType { get; }
  }
}
