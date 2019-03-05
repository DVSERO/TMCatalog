// ------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Jozsef Tolgyesi</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalogClient.Model
{
  using System.ComponentModel.DataAnnotations;
  using TMCatalog.Common.Model;

  /// <summary>
  /// Vehicle type
  /// </summary>
  public class VehicleType : IVehicleType
  {
    /// <summary>
    /// Gets or sets the Id
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the model id
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Gets or sets the Model
    /// </summary>
    public Model Model { get; set; }

    /// <summary>
    /// Gets or sets the tec doc id
    /// </summary>
    public int TecDocID { get; set; }

    /// <summary>
    /// Gets or sets the first production year
    /// </summary>
    public int ProductionYearFrom { get; set; }

    /// <summary>
    /// Gets or sets the last production year
    /// </summary>
    public int ProductionYearTo { get; set; }

    /// <summary>
    /// Gets or sets the fuel type id
    /// </summary>
    public int FuelTypeId { get; set; }

    /// <summary>
    /// Gets or sets the Fuel Type
    /// </summary>
    public FuelType FuelType { get; set; }
  }
}
