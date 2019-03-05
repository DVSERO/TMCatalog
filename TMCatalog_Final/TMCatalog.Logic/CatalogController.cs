// ------------------------------------------------------------------------------------------------------------------
// <copyright file="CatalogController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalog.Logic
{
  using System.Collections.Generic;
  using System.Linq;
  using TMCatalog.Model.DBContext;
  using TMCatalogClient.Model;

  /// <summary>
  /// Catalog controller
  /// </summary>
  public class CatalogController
  {
    /// <summary>
    /// The catalog database
    /// </summary>
    private TMCatalogDB catalogDatabase;
    /// <summary>
    /// Initializes a new instance of the <see cref="CatalogController"/> class.
    /// </summary>
    public CatalogController()
    {
      this.catalogDatabase = new TMCatalogDB();
    }

    /// <summary>
    /// Gets the vehicle types.
    /// </summary>
    /// <returns>Vehicle type list</returns>
    public List<VehicleType> GetVehicleTypes(int modelId)
    {
      return this.catalogDatabase.VehicleTypes.Include("Model").Include("Model.Manufacturer").Include("FuelType").
        Where(x => x.ModelId == modelId).
        OrderBy(m => m.Model.Manufacturer.Description).ThenBy(m => m.Model.Description).ThenBy(m => m.Description).ToList();
    }

    /// <summary>
    /// Gets the vehicle type products.
    /// </summary>
    /// <param name="vehicleTypeID">The vehicle type identifier.</param>
    /// <returns></returns>
    public List<Product> GetVehicleTypeProducts(int vehicleTypeID)
    {
      List<Product> vehicleTypeProducts = (from p in this.catalogDatabase.Products
                                           join v in this.catalogDatabase.VehicleTypeProducts on p.Id equals v.ProductId
                                           where v.VehicleTypeId == vehicleTypeID
                                           select p).ToList();

      return vehicleTypeProducts;
    }

    /// <summary>
    /// Gets the manufacturers.
    /// </summary>
    /// <returns></returns>
    public List<Manufacturer> GetManufacturers()
    {
      return this.catalogDatabase.Manufacturer.ToList();
    }

    public List<Model> GetModels(int manufacturerId)
    {
      return this.catalogDatabase.Models.Where(x => x.ManufacturerId == manufacturerId).ToList();
    }
  }
}
