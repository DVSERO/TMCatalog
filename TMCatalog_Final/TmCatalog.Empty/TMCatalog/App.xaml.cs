using System;
using System.Data.Entity.Migrations;
using System.Windows;
using TMCatalog.Common.MVVM;
using TMCatalog.Model.DBContext;
using TMCatalog.Model.Migrations;
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
      ViewService.RegisterView(typeof(OrderWindowViewModel), typeof(OrderWindow));
      ViewService.RegisterView(typeof(AddPlateNumberViewModel), typeof(AddPlateNumberWindow));
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
        //DBInitializer dbinit = new DBInitializer();
        //dbinit.InitializeDatabase(new TMCatalogDB());

        Configuration configuration = new Configuration();
        DbMigrator migrator = new DbMigrator(configuration);

        //migrator.Update("M1");
        migrator.Update("M2");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
