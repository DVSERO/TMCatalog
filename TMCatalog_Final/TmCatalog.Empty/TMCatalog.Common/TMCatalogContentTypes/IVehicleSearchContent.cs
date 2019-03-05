namespace TMCatalog.Common.TMCatalogContentTypes
{
  public interface IVehicleSearchContent : ITMCatalogContent
  {
    int ManufactureID { get; set; }

    int ModelID { get; set; }
  }
}
