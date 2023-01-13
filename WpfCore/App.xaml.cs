using System.Net.Http;
using System.Windows;
using Csla;
using Csla.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WpfUI
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public class App : Application
  {
    public static ApplicationContext ApplicationContext { get; private set; }
    public static Csla.IDataPortalFactory DataPortalFactory { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
      var services = new ServiceCollection();
      services.AddTransient<HttpClient>();
      services.AddCsla(o => o
        .DataPortal(dp => dp
          .UseHttpProxy(hp => hp
            .DataPortalUrl = "https://localhost:44332/api/dataportal")));
      var provider = services.BuildServiceProvider();
      ApplicationContext = provider.GetService<ApplicationContext>();
      App.DataPortalFactory = provider.GetRequiredService<IDataPortalFactory>();

      base.OnStartup(e);
    }
  }
}