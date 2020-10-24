using System;
using System.Windows;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace LearnWPFPrism
{
    public  class Bootstrapper : UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            // set main window
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            Type sampleModuleType = typeof(SampleModule.SampleModule);

            ModuleCatalog.AddModule(new Prism.Modularity.ModuleInfo
            {
                ModuleName = sampleModuleType.Name,
                ModuleType = sampleModuleType.AssemblyQualifiedName
            });
        }

    }
}
