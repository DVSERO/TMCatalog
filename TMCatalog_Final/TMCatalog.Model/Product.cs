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
  /// Product
  /// </summary>
  public class Product
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
    /// Gets or sets product group id
    /// </summary>
    public int ProductGroupId { get; set; }

    /// <summary>
    /// Gets or sets product group
    /// </summary>
    public ProductGroup ProductGroup { get; set; }
  }
}
