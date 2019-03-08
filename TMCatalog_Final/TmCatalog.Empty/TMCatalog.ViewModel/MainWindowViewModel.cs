// ------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalog.ViewModel
{
  using System;
  using System.Collections.Generic;
  using TMCatalog.Common.MVVM;
  using TMCatalog.Logic;
  using TMCatalogClient.Model;

  /// <summary>
  /// 
  /// </summary>
  /// <seealso cref="TMCatalog.Common.MVVM.ViewModelBase" />
  public class MainWindowViewModel : ViewModelBase
  {
    /// <summary>
    /// The instance
    /// </summary>
    public static CatalogController CatalogController;

    private int tabControlSelectedIndex;

    private ShoppingBasketViewModel shoppingBasketViewModel;

    private VehicleTypeViewModel vehicleTypeViewModel;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
    /// </summary>
    public MainWindowViewModel()
    {
      CatalogController = new CatalogController();
      this.CloseCommand = new RelayCommand(this.CloseCommandExecute);
      this.VehicleSelectionVM = new VehicleSelection();
      this.ShoppingBasketViewModel = new ShoppingBasketViewModel();
      Instance = this;
    }

    /// <summary>
    /// Gets or sets the close command.
    /// </summary>
    /// <value>
    /// The close command.
    /// </value>
    public RelayCommand CloseCommand { get; set; }

    public static MainWindowViewModel Instance { get; private set; }

    public VehicleSelection VehicleSelectionVM { get; set; }

    public VehicleTypeViewModel VehicleTypeViewModel
    {
      get
      {
        return vehicleTypeViewModel;
      }

      set
      {
        vehicleTypeViewModel = value;
        this.RaisePropertyChanged();
      }
    }

    public ShoppingBasketViewModel ShoppingBasketViewModel
    {
      get
      {
        return shoppingBasketViewModel;
      }

      set
      {
        shoppingBasketViewModel = value;
        this.RaisePropertyChanged();
      }
    }


    public int TabControlSelectedIndex
    {
      get
      {
        return tabControlSelectedIndex;
      }

      set
      {
        tabControlSelectedIndex = value;
        this.RaisePropertyChanged();
      }
    }


    /// <summary>
    /// Closes the command execute.
    /// </summary>
    public void CloseCommandExecute()
    {
      ViewService.CloseDialog(this);
    }

    internal void ChangeVehicleSelection(VehicleType vehicleType)
    {
      this.TabControlSelectedIndex = 1;

      this.VehicleTypeViewModel = new VehicleTypeViewModel(vehicleType);
    }

    public void AddArticelToShoppingBasket(Article article)
    {
      this.TabControlSelectedIndex = 2;
      this.ShoppingBasketViewModel.AddToShoppingBasket(article);
    }
  }
}
