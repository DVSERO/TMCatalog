namespace TMCatalog.Common.TMCatalogContentTypes
{
  public interface ITMCatalogContent
  {
    string Header { get; }

    void Init();
  }
}
