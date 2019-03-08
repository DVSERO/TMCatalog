using System;
using System.Windows;
using TMCatalog.Common.MVVM;
using TMCatalog.Model.DBContext;
using TMCatalog.View;
using TMCatalog.ViewModel;

namespace TMCatalog
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);
      this.Initialize();
      this.InitializeData();
      this.OpenMainWindow();
    }


    /// <summary>
    /// Initializes this instance.
    /// </summary>
    private void Initialize()
    {
      ViewService.RegisterView(typeof(MainWindowViewModel), typeof(MainWindow));
    }

    /// <summary>
    /// Opens the main window.
    /// </summary>
    private void OpenMainWindow()
    {
      MainWindow mainWindow = new MainWindow();
      MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();

      ViewService.AddMainWindowToOpened(mainWindowViewModel, mainWindow);
      ViewService.ShowDialog(mainWindowViewModel);

    }

    /// <summary>
    /// Initializes the data.
    /// </summary>
    private void InitializeData()
    {
      try
      {
        DBInitializer dbinit = new DBInitializer();
        dbinit.InitializeDatabase(new TMCatalogDB());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
