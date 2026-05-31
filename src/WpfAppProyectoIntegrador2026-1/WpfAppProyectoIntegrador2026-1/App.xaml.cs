using System.Configuration;
using System.Data;
using System.Windows;
using WpfAppProyectoIntegrador2026_1.Security;

namespace WpfAppProyectoIntegrador2026_1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            SeedData.SeedAdmin();

            base.OnStartup(e);
        }
    }

}
