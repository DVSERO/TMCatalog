// ------------------------------------------------------------------------------------------------------------------
// <copyright file="LoginWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Jozsef Tolgyesi</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalogClient.Model
{
  using System.ComponentModel.DataAnnotations;

  /// <summary>
  /// Fuel type helper class
  /// </summary>
  public class FuelType
  {
    /// <summary>
    /// Gets or sets the id 
    /// </summary>
    [Key]    
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    public string Description { get; set; }
  }
}
