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
  /// Article
  /// </summary>
  public class Article
  {
    /// <summary>
    /// Gets or sets the Id
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the article number
    /// </summary>
    public string ArticleNumber { get; set; }

    /// <summary>
    /// Gets or sets the description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the product id
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the product
    /// </summary>
    public Product Product { get; set; }
  }
}
