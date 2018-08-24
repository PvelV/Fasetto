using Fasetto.Word.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Unity.Lifetime;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Container.Setup();
            Container.container.RegisterType<IUIManager, UIManager>(new ContainerControlledLifetimeManager());

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();
        }
    }
}
