namespace TMCatalog.Common.TMCatalogContentTypes
{
  public interface IVehicleSearchContent : ITMCatalogContent
  {
    int ManufacturerId { get; set; } 

    int ModelId { get; set; }    
  }
}
