// ------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Jozsef Tolgyesi</author>
// ------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMCatalogClient.Model
{
  /// <summary>
  /// Vehicle type associated products
  /// </summary>
  public class VehicleTypeProducts
  {
    /// <summary>
    /// Gets or sets product id
    /// </summary>
    [Key, Column(Order=0)]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets product
    /// </summary>
    public Product Product { get; set; }

    /// <summary>
    /// Gets or sets vehicle type id
    /// </summary>
    [Key, Column(Order=1)]
    public int VehicleTypeId { get; set; }

    /// <summary>
    /// Gets or sets vehicle type
    /// </summary>
    public VehicleType VehicleType { get; set; }
  }
}
