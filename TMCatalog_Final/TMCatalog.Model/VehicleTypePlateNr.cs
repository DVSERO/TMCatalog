// ------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Jozsef Tolgyesi</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalogClient.Model
{
  using System.ComponentModel.DataAnnotations;

  public class VehicleTypePlateNr
  {
    /// <summary>
    /// Gets or sets the plate number.
    /// </summary>
    /// <value>
    /// The plate nuber.
    /// </value>
    [Key]
    public string PlateNr { get; set; }

    /// <summary>
    /// Gets or sets the vehicle type identifier.
    /// </summary>
    /// <value>
    /// The vehicle type identifier.
    /// </value>
    public int VehicleTypeId { get; set; }

    /// <summary>
    /// Gets or sets the type of the vehicle.
    /// </summary>
    /// <value>
    /// The type of the vehicle.
    /// </value>
    public VehicleType VehicleType { get; set; }
  }
}
