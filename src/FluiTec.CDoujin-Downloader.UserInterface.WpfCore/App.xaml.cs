using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using FluiTec.CDoujin_Downloader.UserInterface.WpfCore.Views;
using FluiTec.CDoujin_Downloader.UserInterface.WpfCore.ViewModels;

namespace FluiTec.CDoujin_Downloader.UserInterface.WpfCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfigurationRoot Configuration { get; private set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainView>();
            mainWindow.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(MainViewModel));
            services.AddSingleton(typeof(MainView));
        }
    }
}
