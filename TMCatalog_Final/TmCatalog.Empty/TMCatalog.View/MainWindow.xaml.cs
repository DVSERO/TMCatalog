// ------------------------------------------------------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="DVSE GmbH">
//   Copyright (c) by DVSE Gesellschaft für Datenverarbeitung, Service und Entwicklung mbH. All rights reserved.
// </copyright>
// <author>Szilveszter Gorgicze</author>
// ------------------------------------------------------------------------------------------------------------------

namespace TMCatalog.View
{
  using System;
  using System.Windows;

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      this.Closed += MainWindow_Closed;
    }

    /// <summary>
    /// Handles the Closed event of the MainWindow control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    private void MainWindow_Closed(object sender, EventArgs e)
    {
      Application.Current.Shutdown();
    }
  }
}
