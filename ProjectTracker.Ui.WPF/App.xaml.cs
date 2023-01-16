using System.Windows;
using Csla.Configuration;
using Csla;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;

namespace ProjectTracker.Ui.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
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

            base.OnStartup(e);
        }
    }
}
