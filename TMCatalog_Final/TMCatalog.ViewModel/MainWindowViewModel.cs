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
  using System.Collections.ObjectModel;
  using TMCatalog.Common.MVVM;
  using TMCatalog.Common.TMCatalogContentTypes;
  using TMCatalog.Logic;
  using TMCatalog.ViewModel.UserControls;
  using TMCatalogClient.Model;

  /// <summary>
  /// 
  /// </summary>
  /// <seealso cref="TMCatalog.Common.MVVM.ViewModelBase" />
  public class MainWindowViewModel : ViewModelBase
  {
    public ObservableCollection<ITMCatalogContent> contents;

    ITMCatalogContent selectedContent;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainWindowViewModel" /> class.
    /// </summary>
    public MainWindowViewModel()
    {
      ITMCatalogContent vehicleSearch = new VehicleSearchVM();
      Contents = new ObservableCollection<ITMCatalogContent>();
      Contents.Add(vehicleSearch);      
      MainWindowViewModel.Instance = this;
      this.SelectedContent = vehicleSearch;
    }

    public static MainWindowViewModel Instance { get; internal set; }

    /// <summary>
    /// Gets or sets the contents.
    /// </summary>
    /// <value>
    /// The contents.
    /// </value>
    public ObservableCollection<ITMCatalogContent> Contents
    {
      get
      {
        return contents;
      }

      set
      {
        contents = value;
        this.RaisePropertyChanged();
      }
    }

    public ITMCatalogContent SelectedContent
    {
      get
      {
        return selectedContent;
      }

      set
      {
        this.selectedContent = value;
        this.RaisePropertyChanged();
      }
    }

    internal void OpenVehicle(VehicleType selectedVehicleType)
    {
      VehicleTypeVM vehicleTypeVM = new VehicleTypeVM(selectedVehicleType);
      this.Contents.Add(vehicleTypeVM);
      this.SelectedContent = vehicleTypeVM;
      vehicleTypeVM.Init();
    }
  }
}
