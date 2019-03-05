// ------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Jozsef Tolgyesi</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalogClient.Model
{
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;

  /// <summary>
  /// Vehicle type articles 
  /// </summary>
  public class VehicleTypeArticles
  {
    /// <summary>
    /// Gets or sets the Id
    /// </summary>
    [Key, Column(Order = 0)]
    public int ArticleId { get; set; }

    /// <summary>
    /// Gets or sets the article number
    /// </summary>
    public Article Article { get; set; }

    /// <summary>
    /// Gets or sets the vehicle type identifier.
    /// </summary>
    /// <value>
    /// The vehicle type identifier.
    /// </value>
    [Key, Column(Order = 1)]
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
