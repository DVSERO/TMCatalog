// ------------------------------------------------------------------------------------------------------------------
// <copyright file="CatalogController.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalog.Logic
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using TMCatalog.Common.Enums;
  using TMCatalog.Model;
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

    public List<Manufacturer> GetManufacturers()
    {
      return this.catalogDatabase.Manufacturer.ToList();
    }

    public List<Model> GetModels(int manufacturerID)
    {
      return this.catalogDatabase.Models.Where(m => m.ManufacturerId == manufacturerID).ToList();
    }

    public List<VehicleType> GetVehicleType(int modelID)
    {
      return this.catalogDatabase.VehicleTypes.Include("Model").Include("Model.Manufacturer").Include("FuelType").Where(t => t.ModelId == modelID).ToList();
    }

    public List<ProductGroup> GetProdutGroups(int vehicleTypeID)
    {
      List<ProductGroup> productGroups = new List<ProductGroup>();

      List<VehicleTypeProducts> vehicleTypeProducts = this.catalogDatabase.VehicleTypeProducts.Include("Product").Include("Product.ProductGroup").Where(v => v.VehicleTypeId == vehicleTypeID).ToList();

      if (vehicleTypeProducts?.Count > 0)
      {
        ProductGroup productGroup;
        foreach (VehicleTypeProducts vehicleTypeProduct in vehicleTypeProducts)
        {
          productGroup = productGroups.FirstOrDefault(pg => pg.Id == vehicleTypeProduct.Product.ProductGroupId);
          if (productGroup != null)
          {
            productGroup.ProductList.Add(vehicleTypeProduct.Product);
          }
          else
          {
            productGroup = vehicleTypeProduct.Product.ProductGroup;
            productGroup.ProductList = new List<Product>();
            productGroup.ProductList.Add(vehicleTypeProduct.Product);
            productGroups.Add(productGroup);
          }
        }
      }

      return productGroups;
    }

    public List<Article> GetArticles(int productID)
    {
      return this.catalogDatabase.Articles.Where(a => a.ProductId == productID).ToList();
    }

    public decimal GetArticlePrice(int articleID)
    {
      decimal? value = this.catalogDatabase.Stocks.FirstOrDefault(x => x.ArticleId == articleID)?.Price;
      return value.HasValue ? value.Value : 0;
    }

    public Order GetOpenOrder()
    {
      return this.catalogDatabase.Orders.Include("OrderEntries").Include("OrderEntries.Article")
        .FirstOrDefault(x => x.OrderState == EOrderState.Open);
    }

    public void SetOrder(Order order)
    {
      Order existingOrder = this.catalogDatabase.Orders.Include("OrderEntries")
        .FirstOrDefault(o => o.ID == order.ID);

      if (existingOrder != null)
      {
        existingOrder.OrderEntries = order.OrderEntries;
      }
      else
      {
        this.catalogDatabase.Orders.Add(order);
      }

      this.catalogDatabase.SaveChanges();
    }

    public void CloseOrder(string orderId)
    {
      Order existingOrder = this.catalogDatabase.Orders.FirstOrDefault(o => o.ID == orderId);

      if (existingOrder != null)
      {
        existingOrder.OrderState = EOrderState.Closed;
        this.catalogDatabase.SaveChanges();
      }      
    }

    public List<Order> GetAllOrders()
    {
      return this.catalogDatabase.Orders.Include("OrderEntries").
        Include("OrderEntries.Article").ToList();
    }

    public void SavePlateNr(VehicleTypePlateNr newVehicleTypePlateNr)
    {
      string lowerPlateNr = newVehicleTypePlateNr.PlateNr.ToLower();
      VehicleTypePlateNr plateNr = this.catalogDatabase.VehicleTypePlateNrs
                                                       .FirstOrDefault(x => x.PlateNr == lowerPlateNr);

      if (plateNr != null)
      {
        plateNr.VehicleTypeId = newVehicleTypePlateNr.VehicleTypeId;
        this.catalogDatabase.SaveChanges();
      }
      else
      {
        newVehicleTypePlateNr.PlateNr = lowerPlateNr;
        this.catalogDatabase.VehicleTypePlateNrs.Add(newVehicleTypePlateNr);
        this.catalogDatabase.SaveChanges();
      }
    }
  }
}
